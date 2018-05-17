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

        public class pod_zacuchenie : def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)
            TextBox name_rule;
            TextBox power_istinnosti;
            TextBox activisacia;
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
                activisacia = new TextBox { Width = 50 };
                this.cols.Add(activisacia);
                
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
        view_table table_sociolog;

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