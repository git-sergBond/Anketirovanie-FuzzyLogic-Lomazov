using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анкетирование
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_anketirovanie(object sender, EventArgs e)
        {
            Form ptr = new SignIN();
            ptr.Show();
        }

        private void btn_expert(object sender, EventArgs e)
        {
            new Expert().Show();
        }

        private void btn_sociolog(object sender, EventArgs e)
        {
            Form ptr = new Sociolog1();
            ptr.Show();
        }

        private void btn_konfig(object sender, EventArgs e)
        {
            new Conf_questions().Show();
        }

        private void btn_vivod(object sender, EventArgs e)
        {
            new Conf_rules2().Show();
        }

        private void btn_defazification(object sender, EventArgs e)
        {
            new Defazingcs().Show();
        }
    }
}
