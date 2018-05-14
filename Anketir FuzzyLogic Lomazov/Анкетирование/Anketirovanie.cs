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
using System.Collections;

namespace Анкетирование
{
    public partial class Anketirovanie : Form
    {
        private SQLiteConnection DB; //connect for DB (Артем)

        public Anketirovanie()
        {

            InitializeComponent();

        }
        void Anketirovanie_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(port_db_helper.dbName);

        }


        //генерация вопросов анкеты на форму
        int lenght_arr = 1;
        int padding_left = 30;
        int padding_top = 60;
        int diff_left = 30;
        ArrayList gen_id;
        ArrayList gener_controls_lbl;
        ArrayList gener_controls_type;
        ArrayList gener_controls_otvet;

        void btdown_quest_Click(object sender, EventArgs e) //add questions to form
        {
            DB.Open();
            string id_test = this.id_test.Text.ToString();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from questions where id_test = " + id_test;
            SQLiteDataReader reader = CMD.ExecuteReader();

            if (reader != null)
            {
                gener_controls_lbl = new ArrayList();
                gener_controls_type = new ArrayList();
                gener_controls_otvet = new ArrayList();
                gen_id = new ArrayList();
            }
            else return;

            while (reader.Read())
            {
                lenght_arr++;
                int type = Int32.Parse(reader["id_type"].ToString());

                string quest = (string)reader["question"];

                Label lbl = new Label();
                lbl.Text = quest;
                lbl.Width = 400;

                object otvet = null;
                if (type == 1)//ispravit govnocod
                {
                    otvet = new CheckBox() { Text = "" };
                }
                else
                {
                    //Delaem super scroll
                    otvet = new TrackBar() { Minimum = 2, Maximum = 5 };
                    //Ne delaem 
                }

                gener_controls_lbl.Add(lbl);
                gener_controls_type.Add(type);
                gener_controls_otvet.Add(otvet);
                gen_id.Add(Int32.Parse(reader["id"].ToString()));

                this.Controls.Add(lbl);
                this.Controls.Add(otvet as Control);

                lbl.Left = padding_left;
                lbl.Top = padding_top;
                padding_left += diff_left + lbl.Width;

                (otvet as Control).Left = padding_left;
                (otvet as Control).Top += padding_top;
                padding_top += diff_left + 10;
                padding_left = 30;

                //конец генерации
            }

            DB.Close();
        }


        //описание событий после нажатии кнопки сохранить р-ты 
        private void bt_save_result_clk(object sender, EventArgs e)
        {
            for (int i = 0; i < lenght_arr - 1; i++)
            {
                int answer = 0;

                if (gener_controls_otvet[i] is CheckBox)
                {
                    answer = (gener_controls_otvet[i] as CheckBox).Checked ? 1 : 0;
                }
                if (gener_controls_otvet[i] is TrackBar)
                {
                    answer = (gener_controls_otvet[i] as TrackBar).Value; //тут ошибка при сохранение рез-татов (+компиляции)
                }
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "INSERT INTO `res_testing`(`id_pers`,`id_question`,`answer`) VALUES (" + my_global.id_pers + "," + gen_id[i] + "," + answer + ")";
                CMD.ExecuteNonQuery();
                DB.Close();
            }
        }
    }
}
