using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкетирование
{
    public static class AlgMamdani
    {
        static public class Fazing_alg
        {
            public class data : def_cortege
            {
                public double suhu, s_rendah = 0, s_sedang = 0, s_tinggi = 0, aa, bb, cc, dd, ee, ff, gg, hh, f1, f2, f3, f4, f5, f6, f7, f8, answer1, answer0, sum, number, prosent, summ;
                public double f_v, f_s, f_n, itog_n, itog_s, itog_v;
                public double f_vyvod;
                public void calc_data()
                {
                    //низкий
                    // suhu = proc_or_avrg; ---------------> (0)
                    if (suhu < aa)s_rendah = 1;
                    if (suhu >= aa && suhu <= cc)s_rendah = (cc - suhu) / (cc - aa);
                    if (suhu > cc)s_rendah = 0;
                    
                    // средний 1
                    if (suhu < bb)s_sedang = 0;
                    if (suhu >= bb && suhu <= dd)s_sedang = (suhu - bb) / (dd - bb);
                    if (suhu >= dd && suhu <= ff)s_sedang = 1;
                    if (suhu >= ff && suhu <= gg)s_sedang = (gg - suhu) / (gg - ff);
                    if (suhu > gg)s_sedang = 0;
                    
                    //высокий 1
                    if (suhu < ee)s_tinggi = 0;
                    if (suhu >= ee && suhu <= hh)s_tinggi = (suhu - ee) / (hh - ee);
                    if (suhu > hh)s_tinggi = 1;
                    
                    // B(i) низкий
                    if (s_rendah >= 0)f_vyvod = f1;
                    if (s_rendah > 0.15)f_vyvod = f2;
                    if (s_rendah > 0.3)f_vyvod = f3;
                    if (s_rendah > 0.45) f_vyvod = f4;
                    if (s_rendah > 0.60)f_vyvod = f5;
                    if (s_rendah > 0.75)f_vyvod = f6;
                    if (s_rendah > 0.90)f_vyvod = f7;
                    if (s_rendah == 1)f_vyvod = f8;
                    
                    // B(i) средний
                    if (s_sedang >= 0) f_vyvod = f1;
                    if (s_sedang > 0.15) f_vyvod = f2;
                    if (s_sedang > 0.3) f_vyvod = f3;
                    if (s_sedang > 0.45) f_vyvod = f4;
                    if (s_sedang > 0.60) f_vyvod = f5;
                    if (s_sedang > 0.75) f_vyvod = f6;
                    if (s_sedang > 0.90) f_vyvod = f7;
                    if (s_sedang == 1) f_vyvod = f8;
                    
                    // B(i) высокий
                    if (s_tinggi >= 0) f_vyvod = f1;
                    if (s_tinggi > 0.15) f_vyvod = f2;
                    if (s_tinggi > 0.3) f_vyvod = f3;
                    if (s_tinggi > 0.45) f_vyvod = f4;
                    if (s_tinggi > 0.60) f_vyvod = f5;
                    if (s_tinggi > 0.75) f_vyvod = f6;
                    if (s_tinggi > 0.90) f_vyvod = f7;
                    if (s_tinggi == 1) f_vyvod = f8;
                    
                }
            }

            public class Template
            {
                public SQLiteDataReader reader;
                public int percent;
                public double avg;

                public Template(SQLiteDataReader reader, int percent, double avg)
                {
                    this.reader = reader;
                    this.percent = percent;
                    this.avg = avg;
                }
            } 

            static public ArrayList sbor_data(int id_test)
            {
                ArrayList rez = new ArrayList(); 

                SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "SELECT * FROM rules, questions WHERE questions.id = rules.id_questions  AND questions.id_test = " + id_test;
                SQLiteDataReader reader = CMD.ExecuteReader();
                if (reader == null) return null;
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
                    rez.Add(new Template(reader, (int)percent, avg));
                }
                DB.Close();
                return rez;
            }
        }
    }
}
