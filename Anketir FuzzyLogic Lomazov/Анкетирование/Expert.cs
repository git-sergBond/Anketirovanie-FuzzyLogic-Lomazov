using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анкетирование
{
    public partial class Expert : Form
    {

        int ID_TEST;

        //      ::-------------------------------::
        //      ::ПРЕДСТАВЛЕНИЕ И ПРИВЯЗКА ДАННЫХ::
        //      ::-------------------------------::

        public class question_plus_typeQuest : def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)

            public TextBox a;
            public TextBox b;
            public TextBox c;
            public TextBox d;
            public TextBox e;
            public TextBox f;
            public TextBox g;
            public TextBox h;

            public int id_rules;

            TextBox make_txt(object r)
            {
                TextBox tmp = new TextBox() { Text = r.ToString(), Width = 20 };
                this.cols.Add(tmp);
                return tmp;
            }
            public question_plus_typeQuest(SQLiteDataReader reader)
            {
                //создание 1 колонки
                this.cols.Add(new TextBox() { Text = (string)reader["question"], Width = 400 });

                a = make_txt(reader["a"]);
                b = make_txt(reader["b"]);
                c = make_txt(reader["c"]);
                d = make_txt(reader["d"]);
                e = make_txt(reader["e"]);
                f = make_txt(reader["f"]);
                g = make_txt(reader["g"]);
                h = make_txt(reader["h"]);
                
                id_rules = Int32.Parse(reader["id"].ToString());


            }



        }

        view_table table_1;

        public Expert()
        {
            InitializeComponent();
            table_1 = new view_table(16, 25, 30, this);
        }

        //      ::-----::
        //      ::ФОРМА::
        //      ::-----::

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
            //  CMD.CommandText = "select * from rules, questions where id_test = " + id_test;
            CMD.CommandText = "SELECT * FROM rules, questions WHERE questions.id = rules.id_questions + '0' AND questions.id_test = " + id_test;
            SQLiteDataReader reader = CMD.ExecuteReader();

            if (reader == null) return;

            while (reader.Read())
            {
                table.add_cortege(
                    new question_plus_typeQuest(reader)
                    );
            }
            DB.Close();

        }

        //      ::------------::
        //      ::ВСЯКАЯ GUIня::
        //      ::------------::

        private void btn_confirm_Click(object sender, EventArgs e)
        {//КНОПКА подтвердить загрузку на форму 
            ID_TEST = Int32.Parse(this.txt_id_test.Text.ToString());
            upadate();
            this.lbl_id_test.Text = "Вопрос: ";
            this.txt_id_test.Visible = false;
            this.btn_confirm.Visible = false;
            this.label1.Visible = true;
            this.saveout.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.label9.Visible = true;

        }

        private void saveout_Click(object sender, EventArgs e)
        {//СОХРАНЕНИЕ
            SQLiteConnection connection = new SQLiteConnection(port_db_helper.dbName);
            string str = "";

            foreach (question_plus_typeQuest row in table_1.rows)
            {
                str = ("update rules set a ='" + row.a.Text.ToString() + "', b ='" + row.b.Text.ToString() + "',  c ='" + row.c.Text.ToString() + "', d ='" + row.d.Text.ToString() + "', e ='" + row.e.Text.ToString() + "', f ='" + row.f.Text.ToString() + "',   g ='" + row.g.Text.ToString() + "', h ='" + row.h.Text.ToString() + "' WHERE id='" + row.id_rules + "'");

                row.a.Text.ToString();
                row.b.Text.ToString();
                row.c.Text.ToString();
                row.d.Text.ToString();
                row.e.Text.ToString();
                row.f.Text.ToString();
                row.g.Text.ToString();
                row.h.Text.ToString();
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = str;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(str);
            }


        }
    }
}


