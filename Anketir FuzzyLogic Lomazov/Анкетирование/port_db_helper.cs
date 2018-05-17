using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Анкетирование
{
    public static class port_db_helper
    {
        public static string dbName = "Data Source = TestDB — копия.db";
        public static Int32 is_valid_pers(string login, string pass)
        {
            SQLiteConnection con = new SQLiteConnection(dbName);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT count(*) FROM authorization WHERE login='" + login + "' AND password = '" + pass + "'";
            Int32 count = Int32.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return count;
        }
        public static int get_ID_pers(string login)
        {
            int id = -1;
            SQLiteConnection con = new SQLiteConnection(dbName);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT id FROM authorization WHERE login='" + login + "'";
            id = Int32.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return id;
        }
        //registration (Работает и данные грузятся в базу)
        public static bool registrazia(string login, string pass, string group, string id_type_person)
        {
            SQLiteConnection con = new SQLiteConnection(dbName);
            con.Open(); SQLiteCommand cmd = new SQLiteCommand(con);
            //вставить в табл запись с логином и паролем *и группой
            cmd.CommandText = "INSERT INTO authorization (login, password, id_type_person, `group`) VALUES ('" + login + "','" + pass + "','" + group + "','" + id_type_person + "')";

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {


                MessageBox.Show(e.Message.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }
            con.Close();
            return true;
        }

        ///++++++++++++++++++++
        ///
        public static void delete_question(int id_question)
        {//Удаляет вопрос из таблицы

            if (id_question == -1) return;

            SQLiteConnection DB = new SQLiteConnection(dbName);
            SQLiteCommand CMD = DB.CreateCommand();
            CMD = DB.CreateCommand();
            //CMD.CommandText = "UPDATE questions SET number = number-1 where id_test = @ID_TEST AND number > @number";
            //CMD.Parameters.AddWithValue("@ID_TEST", ID_TEST);
            //CMD.Parameters.AddWithValue("@number", number);

            CMD.CommandText = "DELETE FROM questions WHERE id = @id_question";
            CMD.Parameters.AddWithValue("@id_question", id_question);

            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
        public static void update_question(int id_question, int id_type, string qustion)
        {//обновляет вопрос
            SQLiteConnection DB = new SQLiteConnection(dbName);
            SQLiteCommand CMD = DB.CreateCommand();
            CMD = DB.CreateCommand();
            CMD.CommandText =
                "UPDATE questions SET " +
                    "id_type = " + id_type + ", " +
                    "question = '" + qustion + "'" +
                "WHERE id = " + id_question;

            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }

        public static void insert_question(int id_type, string qustion, int id_test)
        {
            SQLiteConnection DB = new SQLiteConnection(dbName);
            SQLiteCommand CMD = DB.CreateCommand();
            CMD = DB.CreateCommand();
            CMD.CommandText =
                "INSERT INTO questions (`id_type`, `id_test`, `question`) VALUES (" +
                id_type + ", " +
                id_test + ", " +
                "'" + qustion + "'" +
                ")";

            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }

        public static List<String> get_rules(int id_test)
        {
            List<String> result = new List<string>();
            SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM rules WHERE id_tests = " + id_test;
            SQLiteDataReader reader = CMD.ExecuteReader();
            if (reader == null) return null;
            while (reader.Read()) result.Add(reader["name"].ToString());
            DB.Close();
            return result;
        }

        public static void insert_rule(int id_test,
            string conclusion,
            double kof_low, double kof_high,
            int id_type,
            int id_A, int id_A_val,
            int id_B, int id_B_val,
            int id_C, int id_C_val)
        {
            SQLiteConnection DB = new SQLiteConnection(dbName);
            SQLiteCommand CMD = DB.CreateCommand();
            CMD = DB.CreateCommand();
            CMD.CommandText =
                "INSERT INTO conf_rules " +
                "(`id_test`, `conclusion`, `kof_low`, `kof_high`, `id_type`, `id_A`, `id_A_val`, `id_B`, `id_B_val`, `id_C`, `id_C_val`)" +
                "VALUES ( "
                + id_test + ", " +
                " '" + conclusion + "', " +
                kof_low.ToString().Replace(",", ".") + "," + kof_high.ToString().Replace(",", ".") + "," +
                id_type + "," +
                id_A + "," + id_A_val + "," +
                id_B + "," + id_B_val + "," +
                id_C + "," + id_C_val + ")";
            MessageBox.Show(CMD.CommandText.ToString());
            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
        public static void update_rule(
            int id, int num_rule,
            string conclusion,
            double kof, int type_kof,
            int id_type,
            int id_A, int id_A_val,
            int id_B, int id_B_val,
            int id_C, int id_C_val)
        {
            SQLiteConnection DB = new SQLiteConnection(dbName);
            SQLiteCommand CMD = DB.CreateCommand();
            CMD = DB.CreateCommand();
            CMD.CommandText = "UPDATE conf_rules SET" +
                " conclusion= '" + conclusion + "'" +
                ", kof = " + kof.ToString().Replace(",", ".") +
                ", type_kof = " + type_kof +
                ", num_rule = " + num_rule +
                ", id_type = " + id_type +
                ", id_A = " + id_A +
                ", id_A_val = " + id_A_val +
                ", id_B = " + id_B +
                ", id_B_val = " + id_B_val +
                ", id_C = " + id_C +
                ", id_C_val = " + id_C_val +
                " WHERE id = " + id;
            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
        public static void delete_rule(int id_rule)
        {
            if (id_rule == -1) return;

            SQLiteConnection DB = new SQLiteConnection(dbName);
            SQLiteCommand CMD = DB.CreateCommand();
            CMD = DB.CreateCommand();

            CMD.CommandText = "DELETE FROM conf_rules WHERE id = @id_rule";
            CMD.Parameters.AddWithValue("@id_rule", id_rule);

            DB.Open();
            CMD.ExecuteNonQuery();
            DB.Close();
        }
        //+++++++++++++++++++++++++++++++++Sociolog1
        public static int get_count_answed_on_question(int id_quest)
        {
            /*
           Int32 count2 = -1;

           SQLiteConnection DB3 = new SQLiteConnection(port_db_helper.dbName);
           DB3.Open();

           SQLiteCommand CMD3 = DB3.CreateCommand();
           CMD3.CommandText = ("select count(*) from res_testing, questions where questions.id_test =  '" + txt_id_test.Text + "'  AND res_testing.id_question = questions.id AND answer = '1'");
           try { count2 = (Int32)CMD3.ExecuteScalar(); }
           catch { MessageBox.Show("warning count2"); }
           finally
           {
               DB3.Close();
           }
           if (count2 == -1) return;
           */


            Int32 cnt = -1;

            SQLiteConnection DB3 = new SQLiteConnection(port_db_helper.dbName);
            DB3.Open();

            SQLiteCommand CMD3 = DB3.CreateCommand();
            CMD3.CommandText = "select count(*) from res_testing where res_testing.id_question = " + id_quest;
            cnt = Int32.Parse(CMD3.ExecuteScalar().ToString());
            DB3.Close();
           // MessageBox.Show("ALL "+cnt.ToString());
            return cnt;
        }
        public static int get_count_answed_yes( int id_quest)
        {
            Int32 cnt = -1;

            SQLiteConnection DB3 = new SQLiteConnection(port_db_helper.dbName);
            DB3.Open();

            SQLiteCommand CMD3 = DB3.CreateCommand();
            CMD3.CommandText = "select count(*) from res_testing where res_testing.id_question = " + id_quest + " AND  answer = 1";
            cnt = Int32.Parse(CMD3.ExecuteScalar().ToString());
            DB3.Close();
           // MessageBox.Show("YES "+cnt.ToString());
            return cnt;
        }
        public static double  get_avg_answed_2_to_5(int id_quest)
        {
            double avg = -1;
            SQLiteConnection DB3 = new SQLiteConnection(port_db_helper.dbName);
            DB3.Open();

            SQLiteCommand CMD3 = DB3.CreateCommand();
            CMD3.CommandText = "select  AVG(answer) from res_testing where res_testing.id_question = " + id_quest;
            avg = Double.Parse(CMD3.ExecuteScalar().ToString());
            DB3.Close();
            return avg;
        }
    }
}
