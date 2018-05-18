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
            if (j == 2) Bi = get_row.f_sred;//средний
            if (j == 3) Bi = get_row.f_vys;//высокий
            return Bi;
        }

        public class pod_zacuchenie : def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)
            TextBox name_rule;
            TextBox power_istinnosti;
            TextBox activisacia_txt;
            /*-----------------
             * DATA
             */
            int id_type = -1,
                id_A = -1, id_B = -1, id_C = -1,
                id_A_val = -1, id_B_val = -1, id_C_val = -1;
            double kof = -1;  
            /*-----------------
             * OUT
             */
            double stepen_istinnosti = -1, activisatia = -1;

            public pod_zacuchenie(SQLiteDataReader reader)
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
                /*-----------------
                 * * OUT
                 */
                double A=-1, B=-1, C=-1;//считы с социолога по правилу сред низ выс
                A = getFromSociologTable_B_i(id_A, id_A_val);
                B = getFromSociologTable_B_i(id_B, id_B_val);
                C = getFromSociologTable_B_i(id_C, id_C_val);
                switch (id_type){//Defazing(1)
                    case 1:// A & B & C
                        stepen_istinnosti = Math.Min(A, Math.Min(B, C));
                        break;
                    default:
                        MessageBox.Show("Данное условие пока не поддерживается Defazing(1)");
                        break;
                }
                activisatia = stepen_istinnosti * kof;
                power_istinnosti.Text = stepen_istinnosti.ToString();
                activisacia_txt.Text = activisatia.ToString();

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
            table_1 = new view_table(30, 100, 30, this);
        }


        void upadate()
        {

            /*
           * ------------------
           * Делаем расчет как у социолога
           * ------------------
           * Кликаем сначала по социологу!!!
           */

            table_sociolog = my_global.na_formu_defaz;

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

            while (reader.Read())
            { 
                table_1.add_cortege(new pod_zacuchenie(reader));
            }

            DB.Close();
            table_1.redraw_on_form();

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {//ВЫВОДЫ
            ID_TEST = Int32.Parse(this.txt_id_test.Text.ToString());
            upadate();
            my_global.na_formu_defaz = table_1;


        }

        private void button1_Click(object sender, EventArgs e)
        {//ДЕФАЗИФИКАЦИЯ
            this.label1.Text = "Варианты решений: ";
            this.label3.Visible = true;
            this.label4.Visible = true;

            double aa, bb, cc, dd, ee, ff, gg, hh;
            int id_rules;
            double def, akkN, akkS, akkV;
            SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
            DB.Open();

            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM conf_rules, rules, questions WHERE  conf_rules.id_test = " + textBox1.Text;
            SQLiteDataReader reader = CMD.ExecuteReader();


            if (reader == null) return;

            while (reader.Read())
            {
                id_rules = Int32.Parse(reader["id"].ToString());
                aa = Double.Parse(reader["a"].ToString());
                bb = Double.Parse(reader["b"].ToString());
                cc = Double.Parse(reader["c"].ToString());
                dd = Double.Parse(reader["d"].ToString());
                ee = Double.Parse(reader["e"].ToString());
                ff = Double.Parse(reader["f"].ToString());
                gg = Double.Parse(reader["g"].ToString());
                hh = Double.Parse(reader["h"].ToString());

                akkN = Convert.ToDouble(textBox2.Text.ToString());
                akkS = Convert.ToDouble(textBox3.Text.ToString());
                akkV = Convert.ToDouble(textBox4.Text.ToString());

                def = ((aa + cc) * akkN + (bb + dd + ff + gg) * akkS + (ee + hh) * akkV) / (akkN*2+akkS*4+akkS*2);
                textBox5.Text = Convert.ToString(String.Format("{0:0.0}", def));
                //


            }
        }
    }
}