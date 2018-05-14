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
    }
}
