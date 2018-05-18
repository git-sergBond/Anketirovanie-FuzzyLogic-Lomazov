namespace Анкетирование
{
    partial class Conf_rules2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_test = new System.Windows.Forms.TextBox();
            this.load_rules = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_save_all = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.num_rule = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.id_type_LOW = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.id_B_val_LOW = new System.Windows.Forms.ComboBox();
            this.kof_LOW = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.id_C_val_LOW = new System.Windows.Forms.ComboBox();
            this.id_A_LOW = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.id_B_LOW = new System.Windows.Forms.ComboBox();
            this.id_C_LOW = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.id_A_val_LOW = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.id_type_MEDIUM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_B_val_MEDIUM = new System.Windows.Forms.ComboBox();
            this.kof_MEDIUM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_C_val_MEDIUM = new System.Windows.Forms.ComboBox();
            this.id_A_MEDIUM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.id_B_MEDIUM = new System.Windows.Forms.ComboBox();
            this.id_C_MEDIUM = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.id_A_val_MEDIUM = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.id_type_HIGH = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.id_B_val_HIGH = new System.Windows.Forms.ComboBox();
            this.kof_HIGH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.id_C_val_HIGH = new System.Windows.Forms.ComboBox();
            this.id_A_HIGH = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.id_B_HIGH = new System.Windows.Forms.ComboBox();
            this.id_C_HIGH = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.id_A_val_HIGH = new System.Windows.Forms.ComboBox();
            this.conclusion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save_rule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.num_rule.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введи ID теста";
            // 
            // txt_id_test
            // 
            this.txt_id_test.Location = new System.Drawing.Point(22, 53);
            this.txt_id_test.Name = "txt_id_test";
            this.txt_id_test.Size = new System.Drawing.Size(100, 22);
            this.txt_id_test.TabIndex = 1;
            // 
            // load_rules
            // 
            this.load_rules.Location = new System.Drawing.Point(128, 33);
            this.load_rules.Name = "load_rules";
            this.load_rules.Size = new System.Drawing.Size(100, 42);
            this.load_rules.TabIndex = 2;
            this.load_rules.Text = "Загрузить правила";
            this.load_rules.UseVisualStyleBackColor = true;
            this.load_rules.Click += new System.EventHandler(this.load_rules_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_save_all);
            this.groupBox1.Controls.Add(this.load_rules);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id_test);
            this.groupBox1.Location = new System.Drawing.Point(39, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка и Сохранение";
            // 
            // btn_save_all
            // 
            this.btn_save_all.Location = new System.Drawing.Point(588, 33);
            this.btn_save_all.Name = "btn_save_all";
            this.btn_save_all.Size = new System.Drawing.Size(101, 42);
            this.btn_save_all.TabIndex = 3;
            this.btn_save_all.Text = "Сохраннить все в БД";
            this.btn_save_all.UseVisualStyleBackColor = true;
            this.btn_save_all.Click += new System.EventHandler(this.btn_save_all_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Предыдущее <<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "следующее >>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // num_rule
            // 
            this.num_rule.Controls.Add(this.tabControl1);
            this.num_rule.Controls.Add(this.conclusion);
            this.num_rule.Controls.Add(this.label2);
            this.num_rule.Location = new System.Drawing.Point(39, 138);
            this.num_rule.Name = "num_rule";
            this.num_rule.Size = new System.Drawing.Size(709, 342);
            this.num_rule.TabIndex = 6;
            this.num_rule.TabStop = false;
            this.num_rule.Text = "#";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(30, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 258);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.id_type_LOW);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.id_B_val_LOW);
            this.tabPage1.Controls.Add(this.kof_LOW);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.id_C_val_LOW);
            this.tabPage1.Controls.Add(this.id_A_LOW);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.id_B_LOW);
            this.tabPage1.Controls.Add(this.id_C_LOW);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.id_A_val_LOW);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "НИЗКИЙ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // id_type_LOW
            // 
            this.id_type_LOW.FormattingEnabled = true;
            this.id_type_LOW.Location = new System.Drawing.Point(467, 72);
            this.id_type_LOW.Name = "id_type_LOW";
            this.id_type_LOW.Size = new System.Drawing.Size(121, 24);
            this.id_type_LOW.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 38;
            this.label19.Text = "C";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 17);
            this.label20.TabIndex = 37;
            this.label20.Text = "B";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 17);
            this.label21.TabIndex = 36;
            this.label21.Text = "A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(359, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 17);
            this.label22.TabIndex = 35;
            this.label22.Text = "Тип условия =";
            // 
            // id_B_val_LOW
            // 
            this.id_B_val_LOW.FormattingEnabled = true;
            this.id_B_val_LOW.Location = new System.Drawing.Point(467, 148);
            this.id_B_val_LOW.Name = "id_B_val_LOW";
            this.id_B_val_LOW.Size = new System.Drawing.Size(121, 24);
            this.id_B_val_LOW.TabIndex = 31;
            // 
            // kof_LOW
            // 
            this.kof_LOW.Location = new System.Drawing.Point(467, 18);
            this.kof_LOW.Name = "kof_LOW";
            this.kof_LOW.Size = new System.Drawing.Size(121, 22);
            this.kof_LOW.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(445, 181);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 17);
            this.label23.TabIndex = 34;
            this.label23.Text = "=";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(295, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 17);
            this.label24.TabIndex = 24;
            this.label24.Text = "Коф. определенности =";
            // 
            // id_C_val_LOW
            // 
            this.id_C_val_LOW.FormattingEnabled = true;
            this.id_C_val_LOW.Location = new System.Drawing.Point(467, 178);
            this.id_C_val_LOW.Name = "id_C_val_LOW";
            this.id_C_val_LOW.Size = new System.Drawing.Size(121, 24);
            this.id_C_val_LOW.TabIndex = 33;
            // 
            // id_A_LOW
            // 
            this.id_A_LOW.FormattingEnabled = true;
            this.id_A_LOW.Location = new System.Drawing.Point(51, 118);
            this.id_A_LOW.Name = "id_A_LOW";
            this.id_A_LOW.Size = new System.Drawing.Size(388, 24);
            this.id_A_LOW.TabIndex = 25;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(445, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 17);
            this.label25.TabIndex = 32;
            this.label25.Text = "=";
            // 
            // id_B_LOW
            // 
            this.id_B_LOW.FormattingEnabled = true;
            this.id_B_LOW.Location = new System.Drawing.Point(51, 148);
            this.id_B_LOW.Name = "id_B_LOW";
            this.id_B_LOW.Size = new System.Drawing.Size(388, 24);
            this.id_B_LOW.TabIndex = 26;
            // 
            // id_C_LOW
            // 
            this.id_C_LOW.FormattingEnabled = true;
            this.id_C_LOW.Location = new System.Drawing.Point(51, 181);
            this.id_C_LOW.Name = "id_C_LOW";
            this.id_C_LOW.Size = new System.Drawing.Size(388, 24);
            this.id_C_LOW.TabIndex = 27;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(445, 121);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(16, 17);
            this.label26.TabIndex = 30;
            this.label26.Text = "=";
            // 
            // id_A_val_LOW
            // 
            this.id_A_val_LOW.FormattingEnabled = true;
            this.id_A_val_LOW.Location = new System.Drawing.Point(467, 118);
            this.id_A_val_LOW.Name = "id_A_val_LOW";
            this.id_A_val_LOW.Size = new System.Drawing.Size(121, 24);
            this.id_A_val_LOW.TabIndex = 28;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.id_type_MEDIUM);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.id_B_val_MEDIUM);
            this.tabPage2.Controls.Add(this.kof_MEDIUM);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.id_C_val_MEDIUM);
            this.tabPage2.Controls.Add(this.id_A_MEDIUM);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.id_B_MEDIUM);
            this.tabPage2.Controls.Add(this.id_C_MEDIUM);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.id_A_val_MEDIUM);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "СРЕДНИЙ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // id_type_MEDIUM
            // 
            this.id_type_MEDIUM.FormattingEnabled = true;
            this.id_type_MEDIUM.Location = new System.Drawing.Point(477, 75);
            this.id_type_MEDIUM.Name = "id_type_MEDIUM";
            this.id_type_MEDIUM.Size = new System.Drawing.Size(121, 24);
            this.id_type_MEDIUM.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Тип условия =";
            // 
            // id_B_val_MEDIUM
            // 
            this.id_B_val_MEDIUM.FormattingEnabled = true;
            this.id_B_val_MEDIUM.Location = new System.Drawing.Point(477, 151);
            this.id_B_val_MEDIUM.Name = "id_B_val_MEDIUM";
            this.id_B_val_MEDIUM.Size = new System.Drawing.Size(121, 24);
            this.id_B_val_MEDIUM.TabIndex = 47;
            // 
            // kof_MEDIUM
            // 
            this.kof_MEDIUM.Location = new System.Drawing.Point(477, 21);
            this.kof_MEDIUM.Name = "kof_MEDIUM";
            this.kof_MEDIUM.Size = new System.Drawing.Size(121, 22);
            this.kof_MEDIUM.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Коф. определенности =";
            // 
            // id_C_val_MEDIUM
            // 
            this.id_C_val_MEDIUM.FormattingEnabled = true;
            this.id_C_val_MEDIUM.Location = new System.Drawing.Point(477, 181);
            this.id_C_val_MEDIUM.Name = "id_C_val_MEDIUM";
            this.id_C_val_MEDIUM.Size = new System.Drawing.Size(121, 24);
            this.id_C_val_MEDIUM.TabIndex = 49;
            // 
            // id_A_MEDIUM
            // 
            this.id_A_MEDIUM.FormattingEnabled = true;
            this.id_A_MEDIUM.Location = new System.Drawing.Point(61, 121);
            this.id_A_MEDIUM.Name = "id_A_MEDIUM";
            this.id_A_MEDIUM.Size = new System.Drawing.Size(388, 24);
            this.id_A_MEDIUM.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "=";
            // 
            // id_B_MEDIUM
            // 
            this.id_B_MEDIUM.FormattingEnabled = true;
            this.id_B_MEDIUM.Location = new System.Drawing.Point(61, 151);
            this.id_B_MEDIUM.Name = "id_B_MEDIUM";
            this.id_B_MEDIUM.Size = new System.Drawing.Size(388, 24);
            this.id_B_MEDIUM.TabIndex = 42;
            // 
            // id_C_MEDIUM
            // 
            this.id_C_MEDIUM.FormattingEnabled = true;
            this.id_C_MEDIUM.Location = new System.Drawing.Point(61, 184);
            this.id_C_MEDIUM.Name = "id_C_MEDIUM";
            this.id_C_MEDIUM.Size = new System.Drawing.Size(388, 24);
            this.id_C_MEDIUM.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "=";
            // 
            // id_A_val_MEDIUM
            // 
            this.id_A_val_MEDIUM.FormattingEnabled = true;
            this.id_A_val_MEDIUM.Location = new System.Drawing.Point(477, 121);
            this.id_A_val_MEDIUM.Name = "id_A_val_MEDIUM";
            this.id_A_val_MEDIUM.Size = new System.Drawing.Size(121, 24);
            this.id_A_val_MEDIUM.TabIndex = 44;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.id_type_HIGH);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.id_B_val_HIGH);
            this.tabPage3.Controls.Add(this.kof_HIGH);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.id_C_val_HIGH);
            this.tabPage3.Controls.Add(this.id_A_HIGH);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.id_B_HIGH);
            this.tabPage3.Controls.Add(this.id_C_HIGH);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.id_A_val_HIGH);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(637, 229);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ВЫСОКИЙ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // id_type_HIGH
            // 
            this.id_type_HIGH.FormattingEnabled = true;
            this.id_type_HIGH.Location = new System.Drawing.Point(477, 75);
            this.id_type_HIGH.Name = "id_type_HIGH";
            this.id_type_HIGH.Size = new System.Drawing.Size(121, 24);
            this.id_type_HIGH.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 68;
            this.label13.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(369, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 67;
            this.label14.Text = "Тип условия =";
            // 
            // id_B_val_HIGH
            // 
            this.id_B_val_HIGH.FormattingEnabled = true;
            this.id_B_val_HIGH.Location = new System.Drawing.Point(477, 151);
            this.id_B_val_HIGH.Name = "id_B_val_HIGH";
            this.id_B_val_HIGH.Size = new System.Drawing.Size(121, 24);
            this.id_B_val_HIGH.TabIndex = 63;
            // 
            // kof_HIGH
            // 
            this.kof_HIGH.Location = new System.Drawing.Point(477, 21);
            this.kof_HIGH.Name = "kof_HIGH";
            this.kof_HIGH.Size = new System.Drawing.Size(121, 22);
            this.kof_HIGH.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(455, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 66;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(305, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Коф. определенности =";
            // 
            // id_C_val_HIGH
            // 
            this.id_C_val_HIGH.FormattingEnabled = true;
            this.id_C_val_HIGH.Location = new System.Drawing.Point(477, 181);
            this.id_C_val_HIGH.Name = "id_C_val_HIGH";
            this.id_C_val_HIGH.Size = new System.Drawing.Size(121, 24);
            this.id_C_val_HIGH.TabIndex = 65;
            // 
            // id_A_HIGH
            // 
            this.id_A_HIGH.FormattingEnabled = true;
            this.id_A_HIGH.Location = new System.Drawing.Point(61, 121);
            this.id_A_HIGH.Name = "id_A_HIGH";
            this.id_A_HIGH.Size = new System.Drawing.Size(388, 24);
            this.id_A_HIGH.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(455, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 64;
            this.label17.Text = "=";
            // 
            // id_B_HIGH
            // 
            this.id_B_HIGH.FormattingEnabled = true;
            this.id_B_HIGH.Location = new System.Drawing.Point(61, 151);
            this.id_B_HIGH.Name = "id_B_HIGH";
            this.id_B_HIGH.Size = new System.Drawing.Size(388, 24);
            this.id_B_HIGH.TabIndex = 58;
            // 
            // id_C_HIGH
            // 
            this.id_C_HIGH.FormattingEnabled = true;
            this.id_C_HIGH.Location = new System.Drawing.Point(61, 184);
            this.id_C_HIGH.Name = "id_C_HIGH";
            this.id_C_HIGH.Size = new System.Drawing.Size(388, 24);
            this.id_C_HIGH.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(455, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 62;
            this.label18.Text = "=";
            // 
            // id_A_val_HIGH
            // 
            this.id_A_val_HIGH.FormattingEnabled = true;
            this.id_A_val_HIGH.Location = new System.Drawing.Point(477, 121);
            this.id_A_val_HIGH.Name = "id_A_val_HIGH";
            this.id_A_val_HIGH.Size = new System.Drawing.Size(121, 24);
            this.id_A_val_HIGH.TabIndex = 60;
            // 
            // conclusion
            // 
            this.conclusion.Location = new System.Drawing.Point(264, 31);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(407, 22);
            this.conclusion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Варианты принимаемых решений";
            // 
            // save_rule
            // 
            this.save_rule.Location = new System.Drawing.Point(313, 486);
            this.save_rule.Name = "save_rule";
            this.save_rule.Size = new System.Drawing.Size(177, 42);
            this.save_rule.TabIndex = 7;
            this.save_rule.Text = "Сохранить изменения в правиле";
            this.save_rule.UseVisualStyleBackColor = true;
            this.save_rule.Click += new System.EventHandler(this.save_rule_Click);
            // 
            // Conf_rules2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 578);
            this.Controls.Add(this.save_rule);
            this.Controls.Add(this.num_rule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Conf_rules2";
            this.Text = "Conf_rules2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.num_rule.ResumeLayout(false);
            this.num_rule.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_test;
        private System.Windows.Forms.Button load_rules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_save_all;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox num_rule;
        private System.Windows.Forms.TextBox conclusion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox id_type_LOW;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox id_B_val_LOW;
        private System.Windows.Forms.TextBox kof_LOW;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox id_C_val_LOW;
        private System.Windows.Forms.ComboBox id_A_LOW;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox id_B_LOW;
        private System.Windows.Forms.ComboBox id_C_LOW;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox id_A_val_LOW;
        private System.Windows.Forms.ComboBox id_type_MEDIUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox id_B_val_MEDIUM;
        private System.Windows.Forms.TextBox kof_MEDIUM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox id_C_val_MEDIUM;
        private System.Windows.Forms.ComboBox id_A_MEDIUM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox id_B_MEDIUM;
        private System.Windows.Forms.ComboBox id_C_MEDIUM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox id_A_val_MEDIUM;
        private System.Windows.Forms.ComboBox id_type_HIGH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox id_B_val_HIGH;
        private System.Windows.Forms.TextBox kof_HIGH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox id_C_val_HIGH;
        private System.Windows.Forms.ComboBox id_A_HIGH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox id_B_HIGH;
        private System.Windows.Forms.ComboBox id_C_HIGH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox id_A_val_HIGH;
        private System.Windows.Forms.Button save_rule;
    }
}