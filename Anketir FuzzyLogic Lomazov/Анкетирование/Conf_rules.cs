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
    public partial class Conf_rules : Form
    {
        static int ID_TEST;
        view_table table_1;

        public class question_plus_typeQuest : def_cortege
        {//класс хранит ссылки на контроллы + данные (если нужно)

            public const int //То за что отвечают номера ячеек
                CONCLUSION = 0,
                KOF_LOW = 1, KOF_HIGH = 2,
                TYPE_RULE = 3,
                A = 4, B = 5, C = 6,
                VAL_A = 7, VAL_B = 8, VAL_C = 9;

            //немного говнокода <----------
            /* эта херня служит индикатором того, что эта строка не подгружена из БД 
             * она получилась нажатием КНОПКИ добавить вопрос */
            public bool added = false;
            //-----------X

            //ДАННЫЕ 
            public int id;//ID ПРАВИЛА

            void new_txt(string caption, int width)
            {
                TextBox txt = new TextBox() { Text = caption, Width = width };
                this.cols.Add(txt);
            }
            void new_comboBox(int selected, List<string> lines, int width)
            {
                ComboBox box = new ComboBox();
                foreach (string line in lines)
                    box.Items.Add(line);
                box.SelectedIndex = selected - 1;
                this.cols.Add(box);
            }

            //немного говнокода <----------
            /* эти значения должны подгружаться из type_rules и type_val_ABC в БД,
             * но тк время поджимает и так сойдет) */
            List<String> type_rules = new List<string> { "A & B & C", "A & B || C", "A || B & C", "A || B || C", "A & B", "A || B" };
            List<String> type_val_ABC = new List<string> { "низкий", "средний", "высокий" };
            List<String> name_rules;
            //-----------X

            public question_plus_typeQuest(SQLiteDataReader reader)
            {
                name_rules = port_db_helper.get_rules(ID_TEST);

                new_txt(reader["conclusion"].ToString(), 270);
                new_txt(reader["kof_low"].ToString(), 70);
                new_txt(reader["kof_high"].ToString(), 70);
                new_comboBox(Int32.Parse(reader["id_type"].ToString()), type_rules, 80);
                new_comboBox(Int32.Parse(reader["id_A"].ToString()), name_rules, 80);//A
                new_comboBox(Int32.Parse(reader["id_A_val"].ToString()), type_val_ABC, 80); 
                new_comboBox(Int32.Parse(reader["id_B"].ToString()), name_rules, 80);//B
                new_comboBox(Int32.Parse(reader["id_B_val"].ToString()), type_val_ABC, 80);
                new_comboBox(Int32.Parse(reader["id_C_val"].ToString()), name_rules, 80);//C
                new_comboBox(Int32.Parse(reader["id_C_val"].ToString()), type_val_ABC, 80);
                //данные
                this.id = Int32.Parse(reader["id"].ToString());
            }

            public question_plus_typeQuest()
            {
                name_rules = port_db_helper.get_rules(ID_TEST);

                new_txt("conclusion", 270);
                new_txt("kof_low", 70);
                new_txt("kof_high", 70);
                new_comboBox(1, type_rules, 80);
                new_comboBox(1, name_rules, 80);//A
                new_comboBox(1, type_val_ABC, 80);
                new_comboBox(1, name_rules, 80);//B
                new_comboBox(1, type_val_ABC, 80);
                new_comboBox(1, name_rules, 80);//C
                new_comboBox(1, type_val_ABC, 80);
                //данные
                this.id = -1;
            }
        }
        void upadate()
        {
            if (table_1 != null)
            {
                table_1.destroy_table();
            }
            table_1 = new view_table(15, 170, 23, this);
            load_rules(ID_TEST, table_1);
            table_1.redraw_on_form();
        }


        public Conf_rules()
        {
            InitializeComponent();
        }

        

        void load_rules(int id_test, view_table table)
        {//загрузить rules
            SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM conf_rules WHERE id_test = " + id_test;
            SQLiteDataReader reader = CMD.ExecuteReader();
            if (reader == null) return;
            while (reader.Read()) table.add_cortege(new question_plus_typeQuest(reader));
            DB.Close();
        }

        private void btn_load_test_Click(object sender, EventArgs e)
        {//КНОПКА загрузить тест с ID из БД
            ID_TEST = Int32.Parse(this.txt_id_test.Text.ToString());
            upadate();
        }

        private void btn_save_all_Click(object sender, EventArgs e)
        {
            foreach (question_plus_typeQuest row in table_1.rows)
            {

                if (row.added)
                {
                    port_db_helper.insert_rule(
                        ID_TEST,
                        (row.cols[question_plus_typeQuest.CONCLUSION] as TextBox).Text.ToString(),
                        double.Parse((row.cols[question_plus_typeQuest.KOF_LOW] as TextBox).Text.ToString()),
                        double.Parse((row.cols[question_plus_typeQuest.KOF_HIGH] as TextBox).Text.ToString()),
                        (row.cols[question_plus_typeQuest.TYPE_RULE] as ComboBox).SelectedIndex + 1,
                        (row.cols[question_plus_typeQuest.A] as ComboBox).SelectedIndex+1, (row.cols[question_plus_typeQuest.VAL_A] as ComboBox).SelectedIndex + 1,
                        (row.cols[question_plus_typeQuest.B] as ComboBox).SelectedIndex + 1, (row.cols[question_plus_typeQuest.VAL_B] as ComboBox).SelectedIndex + 1,
                        (row.cols[question_plus_typeQuest.C] as ComboBox).SelectedIndex + 1, (row.cols[question_plus_typeQuest.VAL_C] as ComboBox).SelectedIndex + 1);
                }
                else
                {
                    port_db_helper.update_rule(
                        row.id,
                        (row.cols[question_plus_typeQuest.CONCLUSION] as TextBox).Text.ToString(),
                        double.Parse((row.cols[question_plus_typeQuest.KOF_LOW] as TextBox).Text.ToString()),
                        double.Parse((row.cols[question_plus_typeQuest.KOF_HIGH] as TextBox).Text.ToString()),
                        (row.cols[question_plus_typeQuest.TYPE_RULE] as ComboBox).SelectedIndex + 1,
                        (row.cols[question_plus_typeQuest.A] as ComboBox).SelectedIndex + 1, (row.cols[question_plus_typeQuest.VAL_A] as ComboBox).SelectedIndex + 1,
                        (row.cols[question_plus_typeQuest.B] as ComboBox).SelectedIndex + 1, (row.cols[question_plus_typeQuest.VAL_B] as ComboBox).SelectedIndex + 1,
                        (row.cols[question_plus_typeQuest.C] as ComboBox).SelectedIndex + 1, (row.cols[question_plus_typeQuest.VAL_C] as ComboBox).SelectedIndex + 1);
                }

            }
        }

        private void btn_add_rule_Click(object sender, EventArgs e)
        {
            question_plus_typeQuest new_row = new question_plus_typeQuest();
            new_row.added = true;
            table_1.add_cortege(new_row);
            table_1.redraw_on_form();
        }

        private void del_rule_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(id_del_rule.Text.ToString());
            int i = 1;
            int id_rule = -1;
            foreach (question_plus_typeQuest row in table_1.rows)
            {
                if (i == number)
                { id_rule = row.id; break; }
                i++;
            }
            port_db_helper.delete_rule(id_rule);
            upadate();
        }
    }
}
