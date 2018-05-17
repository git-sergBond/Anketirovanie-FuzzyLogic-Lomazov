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
        int ID_TEST;

        //      ::-------------------------------::
        //      ::ПРЕДСТАВЛЕНИЕ И ПРИВЯЗКА ДАННЫХ::
        //      ::-------------------------------::

        public class question_plus_typeQuest : def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)

            public double suhu, s_rendah = 0, s_sedang = 0, s_tinggi = 0, aa, bb, cc, dd, ee, ff, gg, hh, f1, f2, f3, f4, f5, f6, f7, f8, answer1, answer0, sum, number, prosent, summ;
            public double id_type, id_A, id_B, id_C, id_A_val, id_B_val, id_C_val, kof, type_kof, num_rule;
            public double step_istin, aktiviz;
            public int id_rules;

            TextBox make_txt(object r)
            {
                TextBox tmp = new TextBox() { Text = r.ToString(), Width = 20 };
                this.cols.Add(tmp);
                return tmp;
            }

            public question_plus_typeQuest(SQLiteDataReader reader, int percent, double avg)
            {
                //создание 1 колонки
                this.cols.Add(new TextBox() { Text = (string)reader["question"], Width = 300 });

                if (percent != -1)
                {

                }
                if (avg != -1)
                {

                }



                id_rules = Int32.Parse(reader["id"].ToString());
                aa = Double.Parse(reader["a"].ToString());
                bb = Double.Parse(reader["b"].ToString());
                cc = Double.Parse(reader["c"].ToString());
                dd = Double.Parse(reader["d"].ToString());
                ee = Double.Parse(reader["e"].ToString());
                ff = Double.Parse(reader["f"].ToString());
                gg = Double.Parse(reader["g"].ToString());
                hh = Double.Parse(reader["h"].ToString());
                f1 = Double.Parse(reader["f1"].ToString());
                f2 = Double.Parse(reader["f2"].ToString());
                f3 = Double.Parse(reader["f3"].ToString());
                f4 = Double.Parse(reader["f4"].ToString());
                f5 = Double.Parse(reader["f5"].ToString());
                f6 = Double.Parse(reader["f6"].ToString());
                f7 = Double.Parse(reader["f7"].ToString());
                f8 = Double.Parse(reader["f8"].ToString());


                id_type = Double.Parse(reader["id_type"].ToString());
                id_A = Double.Parse(reader["id_A"].ToString());
                id_B = Double.Parse(reader["id_B"].ToString());
                id_C = Double.Parse(reader["id_C"].ToString());
                id_A_val = Double.Parse(reader["id_A_val"].ToString());
                id_B_val = Double.Parse(reader["id_B_val"].ToString());
                id_C_val = Double.Parse(reader["id_C_val"].ToString());
                string conclusion = reader["conclusion"].ToString();
                kof = Double.Parse(reader["kof"].ToString());
                type_kof = Double.Parse(reader["type_kof"].ToString());
                num_rule = Double.Parse(reader["num_rule"].ToString());



                double def, akkN, akkS, akkV;
                //       textBox5.Text = Convert.ToString((aa.ToString()+ bb.ToString())*textBox2.Text

            }



        }

        view_table table_1;

        public object CMD2 { get; private set; }

        public Defazingcs()
        {
            InitializeComponent();
            table_1 = new view_table(16, 25, 50, this);
        }


        void upadate()
        {
            load_test(ID_TEST, table_1);
            table_1.redraw_on_form();
        }



        void load_test(int id, view_table table)
        {//загрузить тест
            SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
            DB.Open();
            string id_test = id.ToString();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM conf_rules, rules, questions WHERE  conf_rules.id_test = " + id_test;
            SQLiteDataReader reader = CMD.ExecuteReader();


            if (reader == null) return;

            while (reader.Read())
            {

                double percent = -1;
                double avg = -1;

                Int32 question_id = Int32.Parse(reader["id_questions"].ToString());

                Int32 all_cnt = port_db_helper.get_count_answed_on_question(question_id);
                Int32 type_quest = Int32.Parse(reader["id_type"].ToString());
                if (type_quest == 1) //если это + - то считаем %
                {
                    Int32 cnt_yes = port_db_helper.get_count_answed_yes(question_id);
                    percent = ((float)cnt_yes * 100.0) / (float)all_cnt;
                }
                else //если это 2..5 то считаем среднее
                {
                    avg = port_db_helper.get_avg_answed_2_to_5(question_id);
                }

                table.add_cortege(new question_plus_typeQuest(reader, (int)percent, avg));
            }
            DB.Close();

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ID_TEST = Int32.Parse(this.txt_id_test.Text.ToString());
            upadate();
            my_global.na_formu_defaz = table_1;
            this.lbl_id_test.Text = "Правило: ";
            this.txt_id_test.Visible = false;
            this.btn_confirm.Visible = false;
            this.label3.Visible = true;
            this.label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Варианты решений: ";
            this.label3.Visible = true;
            this.label4.Visible = true;

            double suhu, s_rendah = 0, s_sedang = 0, s_tinggi = 0, aa, bb, cc, dd, ee, ff, gg, hh, f1, f2, f3, f4, f5, f6, f7, f8, answer1, answer0, sum, number, prosent, summ;
            double id_type, id_A, id_B, id_C, id_A_val, id_B_val, id_C_val, kof, type_kof, num_rule;
            double step_istin, aktiviz;
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
                f1 = Double.Parse(reader["f1"].ToString());
                f2 = Double.Parse(reader["f2"].ToString());
                f3 = Double.Parse(reader["f3"].ToString());
                f4 = Double.Parse(reader["f4"].ToString());
                f5 = Double.Parse(reader["f5"].ToString());
                f6 = Double.Parse(reader["f6"].ToString());
                f7 = Double.Parse(reader["f7"].ToString());
                f8 = Double.Parse(reader["f8"].ToString());


                id_type = Double.Parse(reader["id_type"].ToString());
                id_A = Double.Parse(reader["id_A"].ToString());
                id_B = Double.Parse(reader["id_B"].ToString());
                id_C = Double.Parse(reader["id_C"].ToString());
                id_A_val = Double.Parse(reader["id_A_val"].ToString());
                id_B_val = Double.Parse(reader["id_B_val"].ToString());
                id_C_val = Double.Parse(reader["id_C_val"].ToString());
                string conclusion = reader["conclusion"].ToString();
                kof = Double.Parse(reader["kof"].ToString());
                type_kof = Double.Parse(reader["type_kof"].ToString());
                num_rule = Double.Parse(reader["num_rule"].ToString());

                akkN = Convert.ToDouble(textBox2.Text.ToString());
                akkS = Convert.ToDouble(textBox3.Text.ToString());
                akkV = Convert.ToDouble(textBox4.Text.ToString());

                def = ((aa + cc) * akkN + (bb + dd + ff + gg) * akkS + (ee + hh) * akkV) / (akkN*2+akkS*4+akkS*2);
                textBox5.Text = Convert.ToString(String.Format("{0:0.0}", def));
            }
        }
    }
}