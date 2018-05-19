namespace Анкетирование
{
    partial class Sociolog1
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
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_id_test = new System.Windows.Forms.TextBox();
            this.lbl_id_test = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(100, 30);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(56, 20);
            this.btn_confirm.TabIndex = 12;
            this.btn_confirm.Text = "ОК!";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_id_test
            // 
            this.txt_id_test.Location = new System.Drawing.Point(20, 30);
            this.txt_id_test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_id_test.Name = "txt_id_test";
            this.txt_id_test.Size = new System.Drawing.Size(76, 20);
            this.txt_id_test.TabIndex = 10;
            // 
            // lbl_id_test
            // 
            this.lbl_id_test.AutoSize = true;
            this.lbl_id_test.Location = new System.Drawing.Point(17, 12);
            this.lbl_id_test.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id_test.Name = "lbl_id_test";
            this.lbl_id_test.Size = new System.Drawing.Size(199, 13);
            this.lbl_id_test.TabIndex = 9;
            this.lbl_id_test.Text = "Введите ID теста, для начала работы:";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(335, 9);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(66, 13);
            this.label85.TabIndex = 80;
            this.label85.Text = "% | Среднее";
            this.label85.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(642, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 79;
            this.label23.Text = "B(i) низкий";
            this.label23.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Высокий";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Средний";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Низкий";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "B(i) средний";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "B(i) высокий";
            this.label2.Visible = false;
            // 
            // Sociolog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_id_test);
            this.Controls.Add(this.lbl_id_test);
            this.MaximumSize = new System.Drawing.Size(9998, 9998);
            this.MinimumSize = new System.Drawing.Size(18, 45);
            this.Name = "Sociolog1";
            this.Text = "Sociolog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_id_test;
        private System.Windows.Forms.Label lbl_id_test;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}