using System;
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
    public partial class Conf_rules2 : Form
    {
        public Conf_rules2()
        {
            InitializeComponent();
        }
        const int MAX_CNT_RULES = 2;
        static int ID_TEST = -1;
        //немного говнокода <----------
        /* эти значения должны подгружаться из type_rules и type_val_ABC в БД,
         * но тк время поджимает и так сойдет) */
        static List<String> type_rules = new List<string> { "A & B & C", "A & B || C", "A || B & C", "A || B || C", "A & B", "A || B" };
        static List<String> type_val_ABC = new List<string> { "низкий", "средний", "высокий" };
        static List<String> name_rules;
        static void fill_comboBox(ComboBox box, List<string> lines, int selected)
        {
            foreach (string line in lines)
                box.Items.Add(line);
            box.SelectedIndex = selected - 1;
        }
        //-----------X

        public class Rule_model
        {
            public class Power_rule
            {
                public double kof;
                public int id_type,
                    id_A, id_B, id_C, 
                    id_A_val, id_B_val, id_C_val;
                public int id;
                public int num_rule;
                public int type_kof;
            }

            

            public string conclusion;

            public List<Power_rule> high_medium_low = null;

            public Rule_model()
            {
                high_medium_low = new List<Power_rule>();
                high_medium_low.Add(new Power_rule());
                high_medium_low.Add(new Power_rule());
                high_medium_low.Add(new Power_rule());
            }

            public void load_high_medium_low(int i, SQLiteDataReader reader)
            {
                Power_rule el = high_medium_low[i];

                conclusion = reader["conclusion"].ToString();
                el.kof = Double.Parse(reader["kof"].ToString());
                el.id_type = Int32.Parse(reader["id_type"].ToString());
                el.id_A = Int32.Parse(reader["id_A"].ToString());
                el.id_B = Int32.Parse(reader["id_B"].ToString());
                el.id_C = Int32.Parse(reader["id_C"].ToString());
                el.id_A_val = Int32.Parse(reader["id_A_val"].ToString());
                el.id_B_val = Int32.Parse(reader["id_B_val"].ToString());
                el.id_C_val = Int32.Parse(reader["id_C_val"].ToString());
                el.id = Int32.Parse(reader["id"].ToString());
                el.num_rule = Int32.Parse(reader["num_rule"].ToString());
                el.type_kof = Int32.Parse(reader["type_kof"].ToString());
            }

            public void exec_on_form(Conf_rules2 f)
            {
                f.conclusion.Text = conclusion;
                
                name_rules = port_db_helper.get_rules(ID_TEST);

                Power_rule e = high_medium_low[0];
                f.kof_LOW.Text = e.kof.ToString();
                fill_comboBox(f.id_type_LOW, type_rules, e.id_type);
                fill_comboBox(f.id_A_LOW, name_rules, e.id_A);
                fill_comboBox(f.id_B_LOW, name_rules, e.id_B);
                fill_comboBox(f.id_C_LOW, name_rules, e.id_C);
                fill_comboBox(f.id_A_val_LOW, type_val_ABC, e.id_A_val);
                fill_comboBox(f.id_B_val_LOW, type_val_ABC, e.id_B_val);
                fill_comboBox(f.id_C_val_LOW, type_val_ABC, e.id_C_val);


                e = high_medium_low[1];
                f.kof_MEDIUM.Text = e.kof.ToString();
                fill_comboBox(f.id_type_MEDIUM, type_rules, e.id_type);
                fill_comboBox(f.id_A_MEDIUM, name_rules, e.id_A);
                fill_comboBox(f.id_B_MEDIUM, name_rules, e.id_B);
                fill_comboBox(f.id_C_MEDIUM, name_rules, e.id_C);
                fill_comboBox(f.id_A_val_MEDIUM, type_val_ABC, e.id_A_val);
                fill_comboBox(f.id_B_val_MEDIUM, type_val_ABC, e.id_B_val);
                fill_comboBox(f.id_C_val_MEDIUM, type_val_ABC, e.id_C_val);

                e = high_medium_low[2];
                f.kof_HIGH.Text = e.kof.ToString();
                fill_comboBox(f.id_type_HIGH, type_rules, e.id_type);
                fill_comboBox(f.id_A_HIGH, name_rules, e.id_A);
                fill_comboBox(f.id_B_HIGH, name_rules, e.id_B);
                fill_comboBox(f.id_C_HIGH, name_rules, e.id_C);
                fill_comboBox(f.id_A_val_HIGH, type_val_ABC, e.id_A_val);
                fill_comboBox(f.id_B_val_HIGH, type_val_ABC, e.id_B_val);
                fill_comboBox(f.id_C_val_HIGH, type_val_ABC, e.id_C_val);
            }

            public void load_changed_data_from_view(Conf_rules2 f)
            {
                conclusion   =  f.conclusion.Text.ToString();

                Power_rule e = high_medium_low[0];
                e.kof = double.Parse(f.kof_LOW.Text.ToString());
                e.id_type = f.id_type_LOW.SelectedIndex + 1;
                e.id_A = f.id_A_LOW.SelectedIndex + 1;
                e.id_B = f.id_B_LOW.SelectedIndex + 1;
                e.id_C = f.id_C_LOW.SelectedIndex + 1;
                e.id_A_val = f.id_A_val_LOW.SelectedIndex + 1;
                e.id_B_val = f.id_B_val_LOW.SelectedIndex + 1;
                e.id_C_val = f.id_C_val_LOW.SelectedIndex + 1;


                e = high_medium_low[1];
                e.kof = double.Parse(f.kof_MEDIUM.Text.ToString());
                e.id_type = f.id_type_MEDIUM.SelectedIndex + 1;
                e.id_A = f.id_A_MEDIUM.SelectedIndex + 1;
                e.id_B = f.id_B_MEDIUM.SelectedIndex + 1;
                e.id_C = f.id_C_MEDIUM.SelectedIndex + 1;
                e.id_A_val = f.id_A_val_MEDIUM.SelectedIndex + 1;
                e.id_B_val = f.id_B_val_MEDIUM.SelectedIndex + 1;
                e.id_C_val = f.id_C_val_MEDIUM.SelectedIndex + 1;

                e = high_medium_low[2];
                e.kof = double.Parse(f.kof_HIGH.Text.ToString());
                e.id_type = f.id_type_HIGH.SelectedIndex + 1;
                e.id_A = f.id_A_HIGH.SelectedIndex + 1;
                e.id_B = f.id_B_HIGH.SelectedIndex + 1;
                e.id_C = f.id_C_HIGH.SelectedIndex + 1;
                e.id_A_val = f.id_A_val_HIGH.SelectedIndex + 1;
                e.id_B_val = f.id_B_val_HIGH.SelectedIndex + 1;
                e.id_C_val = f.id_C_val_HIGH.SelectedIndex + 1;

            }

        }


        List<Rule_model> rules = null;
        int cur_rule = -1;

        private void load_rules_Click(object sender, EventArgs e)
        {//КНОПКА загрузить правила
            SQLiteConnection DB = new SQLiteConnection(port_db_helper.dbName);
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            ID_TEST = Int32.Parse(txt_id_test.Text.ToString());
            CMD.CommandText = "SELECT * FROM conf_rules WHERE id_test = " + ID_TEST + " ORDER BY num_rule";
            SQLiteDataReader reader = CMD.ExecuteReader();
            if (reader == null) return;
            rules = new List<Rule_model>();
            int i = 0;
            int j = 0;
            while (reader.Read())
            {
                rules.Add(new Rule_model());
                rules[i].load_high_medium_low(Int32.Parse(reader["type_kof"].ToString())-1, reader);
                j++;
                if(j > MAX_CNT_RULES)
                {
                    i++;
                    j = 0;
                }
            }
            DB.Close();

            cur_rule = 0;
            this.num_rule.Text = "# " + 0 + (cur_rule + 1);

            rules[cur_rule].exec_on_form(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {//СЛЕДУЮЩИЙ
            if (cur_rule < MAX_CNT_RULES)
                cur_rule++;
            this.num_rule.Text = "# " + 0 +(cur_rule + 1);
            rules[cur_rule].exec_on_form(this);
        }

        private void btn_save_all_Click(object sender, EventArgs e)
        {//КНОПКА Созранить все

            foreach (Rule_model model in rules)
            {
                foreach(Rule_model.Power_rule pod_model in model.high_medium_low)
                {
                    port_db_helper.update_rule(pod_model.id,pod_model.num_rule,model.conclusion,pod_model.kof,pod_model.type_kof,pod_model.id_type,pod_model.id_A,pod_model.id_A_val, pod_model.id_B, pod_model.id_B_val, pod_model.id_C, pod_model.id_C_val);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//ПРЕДЫДУЩИЙ
            if (cur_rule != 0)
                cur_rule--;
            this.num_rule.Text = "# " + 0 + (cur_rule + 1);
            rules[cur_rule].exec_on_form(this);
        }

        private void save_rule_Click(object sender, EventArgs e)
        {//КНОПКА Сохранить изменения в правиле
            rules[cur_rule].load_changed_data_from_view(this);
        }
    }
}
