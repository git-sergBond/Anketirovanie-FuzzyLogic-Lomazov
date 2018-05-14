namespace Анкетирование
{
    partial class SignIN
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
            this.btn_in = new System.Windows.Forms.Button();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.txt_id_type_person = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(108, 305);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(164, 23);
            this.btn_in.TabIndex = 0;
            this.btn_in.Text = "Вход";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(108, 100);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(164, 20);
            this.txt_login.TabIndex = 1;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(108, 139);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(164, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reg_bt
            // 
            this.reg_bt.Location = new System.Drawing.Point(108, 334);
            this.reg_bt.Name = "reg_bt";
            this.reg_bt.Size = new System.Drawing.Size(164, 23);
            this.reg_bt.TabIndex = 5;
            this.reg_bt.Text = "Регистрация";
            this.reg_bt.UseVisualStyleBackColor = true;
            this.reg_bt.Click += new System.EventHandler(this.reg_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Группа:";
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(108, 221);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(164, 20);
            this.txt_group.TabIndex = 7;
            // 
            // txt_id_type_person
            // 
            this.txt_id_type_person.Location = new System.Drawing.Point(108, 262);
            this.txt_id_type_person.Name = "txt_id_type_person";
            this.txt_id_type_person.Size = new System.Drawing.Size(164, 20);
            this.txt_id_type_person.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(91, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Добро пожаловать !";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-5, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "  Введите данные для прохождения анкетирования";
            // 
            // SignIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_type_person);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.btn_in);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "SignIN";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.SignIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reg_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.TextBox txt_id_type_person;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}