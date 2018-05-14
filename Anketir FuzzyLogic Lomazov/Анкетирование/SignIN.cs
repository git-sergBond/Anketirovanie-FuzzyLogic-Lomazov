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
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {//+
            //vvod log;pass;group
            string login = txt_login.Text.ToString();
            string pass = txt_pass.Text.ToString();
            string group = txt_group.Text.ToString();
            string id_type_person = txt_id_type_person.Text.ToString();

            int res = port_server.sign_in(login, pass);
            if (res == port_server.ERROR) return;

            my_global.id_store = res;
            Form ptr = new Anketirovanie();
            my_global.id_pers = res; //для загрузки ответов для персоны
            ptr.Show();
        }

        private void reg_bt_Click(object sender, EventArgs e)
        {//+
            string login = txt_login.Text.ToString();
            string pass = txt_pass.Text.ToString();
            string group = txt_group.Text.ToString();
            string id_type_person = txt_id_type_person.Text.ToString();

            int res = port_server.sign_up(login, pass, group, id_type_person);
            if (res == port_server.ERROR) return;

            my_global.id_store = res;

            Form ptr = new Anketirovanie();
            ptr.Show();
        }

        private void SignIN_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
