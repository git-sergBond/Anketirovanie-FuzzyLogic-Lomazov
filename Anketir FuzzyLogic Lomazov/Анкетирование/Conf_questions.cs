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
    public partial class Conf_questions : Form
    {

        int ID_TEST;

        //      ::-------------------------------::
        //      ::ПРЕДСТАВЛЕНИЕ И ПРИВЯЗКА ДАННЫХ::
        //      ::-------------------------------::

        public class question_plus_typeQuest: def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)
            public TextBox qwestion;
            public ComboBox type_otvet;
            public int id_question;

            //немного говнокода <----------
            /* эта херня служит индикатором того, что эта строка не подгружена из БД */
            /* она получилась нажатием КНОПКИ добавить вопрос */
            public bool added = false;
            //-----------X

            public question_plus_typeQuest(string question, int id_type, int id_question = -1)
            {
                //создание 1 колонки
                qwestion = new TextBox() { Text = question, Width = 400 };
                this.cols.Add(qwestion);
                //создание 2 колонки
                type_otvet = new ComboBox();
                type_otvet.Items.Add("Да/Нет");
                type_otvet.Items.Add("2..5");
                type_otvet.SelectedIndex = id_type - 1;
                this.cols.Add(type_otvet);
                //данные
                this.id_question = id_question;
            }
        }

        view_table table_1;

        public Conf_questions()
        {
            InitializeComponent();
            table_1 = new view_table(50, 140, 30, this);
        }

        //      ::-----::
        //      ::ФОРМА::
        //      ::-----::

        void upadate()
        {
            if (table_1 != null)
            {
                table_1.destroy_table();
            }
            table_1 = new view_table(50, 140, 30, this);
            load_test(ID_TEST, table_1);
            table_1.redraw_on_form();
        }

        void load_test(int id, view_table table)
        {//загрузить тест
            SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
            DB.Open();
            string id_test = id.ToString();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from questions where id_test = " + id_test;
            SQLiteDataReader reader = CMD.ExecuteReader();

            if (reader == null) return;

            while (reader.Read())
            {
                table.add_cortege(
                    new question_plus_typeQuest(
                        (string)reader["question"],
                        Int32.Parse(reader["id_type"].ToString()),
                        Int32.Parse(reader["id"].ToString())
                        )
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
            this.lbl_id_test.Text = "";
            this.txt_id_test.Visible = false;
            this.btn_confirm.Visible = false;
            make_visible();
        }                                  

        //      ::-----------------------::
        //      ::РЕДАКТИРОВАНИЕ ВОПРОСОВ::
        //      ::-----------------------::
        private void btn_del_qwestion_Click(object sender, EventArgs e)
        {//КНОПКА убрать вопрос
            int number = Int32.Parse(txt_id_del_question.Text.ToString());
            int i = 1;
            int id_question = -1;
            foreach(question_plus_typeQuest row in table_1.rows)
            {
                if(i == number)
                { id_question = row.id_question; break; }
                i++;
            }
            port_db_helper.delete_question(id_question);
            upadate();
        }

        private void btn_add_question_Click(object sender, EventArgs e)
        {//КНОПКА добавить вопрос
            question_plus_typeQuest new_row = new question_plus_typeQuest("Новый вопрос",1);
            new_row.added = true;
            table_1.add_cortege(new_row);
            table_1.redraw_on_form();
        }

        private void btn_save_all_qyesions_Click(object sender, EventArgs e)
        {//КНОПКА сохранить все
            foreach (question_plus_typeQuest row in table_1.rows)
            {
                if (row.added)
                {
                    port_db_helper.insert_question(
                        row.type_otvet.SelectedIndex + 1,
                        row.qwestion.Text.ToString(), 
                        ID_TEST);
                }
                else
                {
                    port_db_helper.update_question(
                        row.id_question,
                        row.type_otvet.SelectedIndex + 1,
                        row.qwestion.Text.ToString());
                }
                
            }
        }

        //      ::------------------------------::
        //      ::МАНИПУЛЯЦИИ С ЭЛЕМЕНТАМИ ФОРМЫ::
        //      ::------------------------------::
        void make_visible()
        {//делает часть элементов видимыми
            this.my_data_grid.Visible = true;
            this.btn_save_all_qyesions.Visible = true;
            this.btn_add_question.Visible = true;
            this.btn_del_qwestion.Visible = true;
            this.txt_id_del_question.Visible = true;
        }
        private void btn_new_test_Click(object sender, EventArgs e)
        {//КНОПКА новый тест
            this.lbl_id_test.Text = "";
            make_visible();
        }

        private void btn_load_test_Click(object sender, EventArgs e)
        {//КНОПКА загрузить тест по ID
            this.lbl_id_test.Text = "Введите ID теста, для начала работы:";
            this.txt_id_test.Visible = true;
            this.btn_confirm.Visible = true;
        }
    }
}
