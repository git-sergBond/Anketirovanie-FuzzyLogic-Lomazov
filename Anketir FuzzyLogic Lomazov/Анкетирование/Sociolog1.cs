/*using System;
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
    public partial class Sociolog1 : Form
    {
        int ID_TEST;

        //      ::-------------------------------::
        //      ::ПРЕДСТАВЛЕНИЕ И ПРИВЯЗКА ДАННЫХ::
        //      ::-------------------------------::

        public class bind_soc : AlgMamdani.Fazing_alg.data
        {//класс хранит ссылки на контроллы + данные (если нужно)

            public TextBox f_vys;
            public TextBox f_sred;
            public TextBox f_niz;
            public TextBox itog_niz;
            public TextBox itog_sred;
            public TextBox itog_vys;
            public TextBox proc_or_avrg;

            public int id_rules;
            TextBox make_txt(object r)
            {
                TextBox tmp = new TextBox() { Text = r.ToString(), Width = 20 };
                this.cols.Add(tmp);
                return tmp;
            }

            public bind_soc(AlgMamdani.Fazing_alg.Template t)
            {
                SQLiteDataReader reader = t.reader;
                int percent = t.percent;
                double avg = t.avg;


                //низкий
                //создание 1 колонки
                this.cols.Add(new TextBox() { Text = (string)reader["question"], Width = 300 });
                if (percent != -1)
                {
                    proc_or_avrg = new TextBox() { Text = percent.ToString()+"%", Width = 30 };
                    this.cols.Add(proc_or_avrg);
                    suhu = percent;//<--(0)
                }
                if (avg != -1)
                {
                    proc_or_avrg = new TextBox() { Text = avg.ToString(), Width = 30 };
                    this.cols.Add(proc_or_avrg);//<--(0)
                    suhu = avg;
                }
                itog_niz = make_txt(itog_n);
                itog_sred = make_txt(itog_s);
                itog_vys = make_txt(itog_v);
              
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

                this.calc_data();

                itog_niz.Text = String.Format("{0:0.0}", s_rendah);
                itog_sred.Text = String.Format("{0:0.0}", s_sedang);
                itog_vys.Text = String.Format("{0:0.0}", s_tinggi);
                f_niz = new TextBox() { Text = f_vyvod.ToString(), Width = 20 };
                this.cols.Add(f_niz);
                f_sred = new TextBox() { Text = f_vyvod.ToString(), Width = 20 };
                this.cols.Add(f_sred);
                f_vys = new TextBox() { Text = f_vyvod.ToString(), Width = 20 };
                this.cols.Add(f_vys);

            }
        }

        view_table table_1;

        public Sociolog1()
        {
            InitializeComponent();
            table_1 = new view_table(16, 25, 50, this);
        }

        void upadate()
        {
            foreach (AlgMamdani.Fazing_alg.Template vspomogat in AlgMamdani.Fazing_alg.sbor_data(ID_TEST)) {//загрузить
                table_1.add_cortege(new bind_soc(vspomogat));
            }
            table_1.redraw_on_form();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ID_TEST = Int32.Parse(this.txt_id_test.Text.ToString());
            upadate();
            my_global.na_formu_defaz = table_1;
            this.lbl_id_test.Text = "Вопрос: ";
            this.txt_id_test.Visible = false;
            this.btn_confirm.Visible = false;
            this.label1.Visible = true;
            this.label3.Visible = true;
            this.label23.Visible = true;
            this.label5.Visible = true;
            this.label85.Visible = true;
            this.label4.Visible = true;
            this.label2.Visible = true;
        }
    }

}
*/
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
    public partial class Sociolog1 : Form
    {
        int ID_TEST;

        //      ::-------------------------------::
        //      ::ПРЕДСТАВЛЕНИЕ И ПРИВЯЗКА ДАННЫХ::
        //      ::-------------------------------::

        public class question_plus_typeQuest : def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)

            public double suhu, s_rendah = 0, s_sedang = 0, s_tinggi = 0, aa, bb, cc, dd, ee, ff, gg, hh, f1, f2, f3, f4, f5, f6, f7, f8, answer1, answer0, sum, number, prosent, summ;
            public double f_v, f_s, f_n, itog_n, itog_s, itog_v;
            public double f_vyvod;
            public double f_vys;
            public double f_sred;
            public double f_niz;



            public TextBox f_vys_txt;
            public TextBox f_sred_txt;
            public TextBox f_niz_txt;
            public TextBox itog_niz;
            public TextBox itog_sred;
            public TextBox itog_vys;
            public TextBox proc_or_avrg;


            public int id_rules;


            TextBox make_txt(object r)
            {
                TextBox tmp = new TextBox() { Text = r.ToString(), Width = 20 };
                this.cols.Add(tmp);
                return tmp;
            }

            public question_plus_typeQuest(SQLiteDataReader reader, int percent, double avg)
            {

                //низкий


                //

                //создание 1 колонки
                this.cols.Add(new TextBox() { Text = (string)reader["question"], Width = 300 });

                if (percent != -1)
                {
                    proc_or_avrg = new TextBox() { Text = percent.ToString() + "%", Width = 30 };
                    this.cols.Add(proc_or_avrg);
                    suhu = percent;//<--(0)
                }
                if (avg != -1)
                {
                    proc_or_avrg = new TextBox() { Text = avg.ToString(), Width = 30 };
                    this.cols.Add(proc_or_avrg);//<--(0)
                    suhu = avg;
                }











                itog_niz = make_txt(itog_n);
                itog_sred = make_txt(itog_s);
                itog_vys = make_txt(itog_v);



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


                //низкий
                // suhu = proc_or_avrg; ---------------> (0)
                if (suhu < aa)
                {
                    s_rendah = 1;
                }
                if (suhu >= aa && suhu <= cc)
                {
                    s_rendah = (cc - suhu) / (cc - aa);
                }

                if (suhu > cc)
                {
                    s_rendah = 0;
                }

                itog_niz.Text = String.Format("{0:0.0}", s_rendah);

                // средний 1


                if (suhu < bb)
                {
                    s_sedang = 0;
                }
                if (suhu >= bb && suhu <= dd)
                {
                    s_sedang = (suhu - bb) / (dd - bb);
                }
                if (suhu >= dd && suhu <= ff)
                {
                    s_sedang = 1;
                }
                if (suhu >= ff && suhu <= gg)
                {
                    s_sedang = (gg - suhu) / (gg - ff);
                }
                if (suhu > gg)
                {
                    s_sedang = 0;
                }
                itog_sred.Text = String.Format("{0:0.0}", s_sedang);


                //высокий 1


                if (suhu < ee)
                {
                    s_tinggi = 0;
                }
                if (suhu >= ee && suhu <= hh)
                {
                    s_tinggi = (suhu - ee) / (hh - ee);
                }
                if (suhu > hh)
                {
                    s_tinggi = 1;
                }
                itog_vys.Text = String.Format("{0:0.0}", s_tinggi);




                // B(i) низкий
                if (s_rendah >= 0)
                {
                    f_vyvod = f1;
                }
                if (s_rendah > 0.15)
                {
                    f_vyvod = f2;
                }
                if (s_rendah > 0.3)
                {
                    f_vyvod = f3;
                }
                if (s_rendah > 0.45)
                {
                    f_vyvod = f4;
                }
                if (s_rendah > 0.60)
                {
                    f_vyvod = f5;
                }
                if (s_rendah > 0.75)
                {
                    f_vyvod = f6;
                }
                if (s_rendah > 0.90)
                {
                    f_vyvod = f7;
                }
                if (s_rendah == 1)
                {
                    f_vyvod = f8;
                }
                f_niz = f_vyvod;
                f_niz_txt = new TextBox() { Text = f_niz.ToString(), Width = 20 };
                this.cols.Add(f_niz_txt);





                // B(i) средний
                if (s_sedang >= 0)
                {
                    f_vyvod = f1;
                }
                if (s_sedang > 0.15)
                {
                    f_vyvod = f2;
                }
                if (s_sedang > 0.3)
                {
                    f_vyvod = f3;
                }
                if (s_sedang > 0.45)
                {
                    f_vyvod = f4;
                }
                if (s_sedang > 0.60)
                {
                    f_vyvod = f5;
                }
                if (s_sedang > 0.75)
                {
                    f_vyvod = f6;
                }
                if (s_sedang > 0.90)
                {
                    f_vyvod = f7;
                }
                if (s_sedang == 1)
                {
                    f_vyvod = f8;
                }
                f_sred = f_vyvod;
                f_sred_txt = new TextBox() { Text = f_sred.ToString(), Width = 20 };
                this.cols.Add(f_sred_txt);








                // B(i) высокий
                if (s_tinggi >= 0)
                {
                    f_vyvod = f1;
                }
                if (s_tinggi > 0.15)
                {
                    f_vyvod = f2;
                }
                if (s_tinggi > 0.3)
                {
                    f_vyvod = f3;
                }
                if (s_tinggi > 0.45)
                {
                    f_vyvod = f4;
                }
                if (s_tinggi > 0.60)
                {
                    f_vyvod = f5;
                }
                if (s_tinggi > 0.75)
                {
                    f_vyvod = f6;
                }
                if (s_tinggi > 0.90)
                {
                    f_vyvod = f7;
                }
                if (s_tinggi == 1)
                {
                    f_vyvod = f8;
                }
                f_vys = f_vyvod;
                f_vys_txt = new TextBox() { Text = f_vys.ToString(), Width = 20 };
                this.cols.Add(f_vys_txt);






            }



        }

        view_table table_1;

        public object CMD2 { get; private set; }

        public Sociolog1()
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
            CMD.CommandText = "SELECT * FROM rules, questions WHERE questions.id = rules.id_questions  AND questions.id_test = " + id_test;
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
            this.lbl_id_test.Text = "Вопрос: ";
            this.txt_id_test.Visible = false;
            this.btn_confirm.Visible = false;
            this.label1.Visible = true;
            this.label3.Visible = true;
            this.label23.Visible = true;
            this.label5.Visible = true;
            this.label85.Visible = true;
            this.label4.Visible = true;
            this.label2.Visible = true;
        }
    }

}