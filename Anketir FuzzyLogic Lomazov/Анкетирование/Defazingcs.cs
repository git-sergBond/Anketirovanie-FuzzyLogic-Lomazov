using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Анкетирование
{
    public partial class Defazingcs : Form
    {
        int ID_TEST = -1;

        //      ::-------------------------------::
        //      ::ПРЕДСТАВЛЕНИЕ И ПРИВЯЗКА ДАННЫХ::
        //      ::-------------------------------::

        static List<pod_zacuchenie> rezultat = new List<pod_zacuchenie>();//хранится процент дефазификаии

        static double getFromSociologTable_B_i(int i/*Номер вопроса(строки)*/, int j/*выбор из {низкий|средний|высокий} кофициент (столбец)*/)
        {//берет данные о расчитанном значении Bi с формы Социолога
            double Bi = -1;
            int counter = 1;
            Sociolog1.question_plus_typeQuest get_row = null;
            foreach (Sociolog1.question_plus_typeQuest row in  table_sociolog.rows)
            {
                if(counter == i) { get_row = row; break; }
                counter++;
            } if (get_row == null) return -2;
            if (j == 1) Bi = get_row.f_niz;//низкий
            else if (j == 2) Bi = get_row.f_sred;//средний
            else if (j == 3) Bi = get_row.f_vys;//высокий
            else MessageBox.Show("функция getFromSociologTable_B_i");
            return Bi;
        }

        public class pod_zacuchenie : def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)
            TextBox name_rule;
            TextBox power_istinnosti;
            TextBox activisacia_txt;
            public TextBox procent_defazific = null;
            /*-----------------
             * DATA
             */
            int id_type = -1,
                id_A = -1, id_B = -1, id_C = -1,
                id_A_val = -1, id_B_val = -1, id_C_val = -1;
            double kof = -1, aa, bb, cc, dd, ee, ff, gg, hh;  
            /*-----------------
             * OUT
             */
            double stepen_istinnosti = -1, activisatia = -1;
            public double def = -1;

            public pod_zacuchenie(SQLiteDataReader reader, int kostl_dla_out_znacheni)
            {
                string[] tmp = new string[] { "Высокий", "Средний" , "Низкий"};
                Label capt1 = new Label { Text = tmp[Int32.Parse(reader["type_kof"].ToString())-1] , Width = 50 };
                this.cols.Add(capt1);
                //правило
                name_rule = new TextBox { Text = reader["conclusion"].ToString(),  Width = 200 };
                this.cols.Add(name_rule);
                //степень истинности
                power_istinnosti = new TextBox { Width = 50 };
                this.cols.Add(power_istinnosti);
                //активизация
                activisacia_txt = new TextBox { Width = 50 };
                this.cols.Add(activisacia_txt);

                if (kostl_dla_out_znacheni % 3 == 0)
                {

                    procent_defazific = new TextBox() { Width = 50 };
                    this.cols.Add(procent_defazific);
                    rezultat.Add(this);
                }

                /*-----------------
                 * DATA
                 */
                id_type = Int32.Parse(reader["id_type"].ToString());
                kof = Double.Parse(reader["kof"].ToString());
                id_A = Int32.Parse(reader["id_A"].ToString());
                id_B = Int32.Parse(reader["id_B"].ToString());
                id_C = Int32.Parse(reader["id_C"].ToString());
                id_A_val = Int32.Parse(reader["id_A_val"].ToString());
                id_B_val = Int32.Parse(reader["id_B_val"].ToString());
                id_C_val = Int32.Parse(reader["id_C_val"].ToString());
                aa = Double.Parse(reader["a"].ToString());
                bb = Double.Parse(reader["b"].ToString());
                cc = Double.Parse(reader["c"].ToString());
                dd = Double.Parse(reader["d"].ToString());
                ee = Double.Parse(reader["e"].ToString());
                ff = Double.Parse(reader["f"].ToString());
                gg = Double.Parse(reader["g"].ToString());
                hh = Double.Parse(reader["h"].ToString());
                /*-----------------
                 * * OUT //РАСЧЕТ ВЫВОДОВ
                 */
                double A =-1, B=-1, C=-1;//считы с социолога по правилу сред низ выс
                A = getFromSociologTable_B_i(id_A, id_A_val);
                B = getFromSociologTable_B_i(id_B, id_B_val);
                C = getFromSociologTable_B_i(id_C, id_C_val);
                switch (id_type){//Defazing(1)
                    case 1:// A & B & C
                        stepen_istinnosti = Math.Min(A, Math.Min(B, C));
                        break;
                    case 2:// A & B || C
                        stepen_istinnosti = Math.Min(A, Math.Max(B, C));
                        break;
                    case 3://A || B & C
                        stepen_istinnosti = Math.Min(Math.Max(A, B), C);
                        break;
                    case 4://A || B || C
                        stepen_istinnosti = Math.Max(A, Math.Max(B, C));
                        break;
                    case 5://A & B
                        stepen_istinnosti = Math.Min(A,B);
                        break;
                    case 6://A || B
                        stepen_istinnosti = Math.Max(A, B);
                        break;
                    default:
                        MessageBox.Show("Данное условие пока не поддерживается Defazing(1)");
                        break;
                }
                activisatia = stepen_istinnosti * kof;
                power_istinnosti.Text = Convert.ToString(String.Format("{0:0.0}", stepen_istinnosti));
                activisacia_txt.Text = Convert.ToString(String.Format("{0:0.0}", activisatia));



                //РАСЧЕТ ДЕФАЗИФИКАЦИЯ
                if (kostl_dla_out_znacheni % 3 == 0)
                {
                    double akkN = -1, akkS = -1, akkV = -1;

                    //ТУТ НУЖНО ИСПРАВИТЬ ОШИБКУ КОГДА НЕ СОВПАДАЕТ НУМЕРАЦИЯ И НИЗ И  СРЕДНИЙ
                    akkN = rezultat[0].activisatia;
                    akkS = rezultat[1].activisatia;
                    akkV = rezultat[2].activisatia;

                    def = (((aa + cc) * akkN) + ((bb + dd + ff + gg) * akkS) + ((ee + hh) * akkV)) / ((akkN * 2) + (akkS * 4) + (akkV * 2));
          
                    if ((akkN * 2 + akkS * 4 + akkS * 2) == 0)
                    {
                        //MessageBox.Show("Не число /0");
                    }
                    procent_defazific.Text =  Convert.ToString(String.Format("{0:0.0}", def)) +"%";
                }
            }
        }

        public class bind_soc : AlgMamdani.Fazing_alg.data
        {
            bind_soc()
            {
                this.calc_data();
            }
        }

        view_table table_1;
        static view_table table_sociolog;

        public Defazingcs()
        {
            InitializeComponent();
            table_1 = new view_table(30, 100, 40, this);
        }


        void upadate()
        {

            /*
           * ------------------
           * Делаем расчет как у социолога
           * ------------------
           * nedofix(Кликаем) сначала по социологу!!!
           */
            table_sociolog = new view_table(0,0,0,this);
            Sociolog1 tmp = new Sociolog1();
            tmp.ID_TEST = ID_TEST;
            tmp.load_test(tmp.ID_TEST, table_sociolog);

            /*
             * ------------------
             * Нарисовали таблицу
             * ------------------
             */

            SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
            SQLiteCommand CMD = DB.CreateCommand();
            CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM conf_rules";
            DB.Open();
            SQLiteDataReader reader =  CMD.ExecuteReader();

            //РАСЧЕТ ВЫВОДОВ
            int i = 1;
            while (reader.Read())
            {
                pod_zacuchenie p = new pod_zacuchenie(reader, i);
                rezultat.Add(p);
                table_1.add_cortege(p);
                if (i == 3) {
                    i = 1;
                    rezultat = new List<pod_zacuchenie>();
                    continue;
                }
                i++;
            }
            DB.Close();
            table_1.redraw_on_form();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ID_TEST = Int32.Parse(this.txt_id_test.Text.ToString());
            upadate();
            my_global.na_formu_defaz = table_1;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}