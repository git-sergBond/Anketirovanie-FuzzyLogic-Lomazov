namespace Анкетирование
{
    partial class Conf_questions
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
            this.btn_load_test = new System.Windows.Forms.Button();
            this.btn_new_test = new System.Windows.Forms.Button();
            this.lbl_id_test = new System.Windows.Forms.Label();
            this.txt_id_test = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.my_data_grid = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save_all_qyesions = new System.Windows.Forms.Button();
            this.btn_add_question = new System.Windows.Forms.Button();
            this.btn_del_qwestion = new System.Windows.Forms.Button();
            this.txt_id_del_question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_load_test
            // 
            this.btn_load_test.Location = new System.Drawing.Point(253, 13);
            this.btn_load_test.Name = "btn_load_test";
            this.btn_load_test.Size = new System.Drawing.Size(104, 33);
            this.btn_load_test.TabIndex = 2;
            this.btn_load_test.Text = "Загрузить";
            this.btn_load_test.UseVisualStyleBackColor = true;
            this.btn_load_test.Click += new System.EventHandler(this.btn_load_test_Click);
            // 
            // btn_new_test
            // 
            this.btn_new_test.Location = new System.Drawing.Point(26, 12);
            this.btn_new_test.Name = "btn_new_test";
            this.btn_new_test.Size = new System.Drawing.Size(186, 35);
            this.btn_new_test.TabIndex = 3;
            this.btn_new_test.Text = "Создать тест (в разраб.)";
            this.btn_new_test.UseVisualStyleBackColor = true;
            this.btn_new_test.Visible = false;
            this.btn_new_test.Click += new System.EventHandler(this.btn_new_test_Click);
            // 
            // lbl_id_test
            // 
            this.lbl_id_test.AutoSize = true;
            this.lbl_id_test.Location = new System.Drawing.Point(34, 64);
            this.lbl_id_test.Name = "lbl_id_test";
            this.lbl_id_test.Size = new System.Drawing.Size(0, 17);
            this.lbl_id_test.TabIndex = 4;
            // 
            // txt_id_test
            // 
            this.txt_id_test.Location = new System.Drawing.Point(323, 59);
            this.txt_id_test.Name = "txt_id_test";
            this.txt_id_test.Size = new System.Drawing.Size(100, 22);
            this.txt_id_test.TabIndex = 5;
            this.txt_id_test.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "или";
            this.label2.Visible = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(429, 53);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 34);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "ОК!";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Visible = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // my_data_grid
            // 
            this.my_data_grid.ColumnCount = 2;
            this.my_data_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.94636F));
            this.my_data_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05364F));
            this.my_data_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.my_data_grid.Location = new System.Drawing.Point(26, 139);
            this.my_data_grid.Name = "my_data_grid";
            this.my_data_grid.RowCount = 1;
            this.my_data_grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.my_data_grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.my_data_grid.Size = new System.Drawing.Size(522, 27);
            this.my_data_grid.TabIndex = 6;
            this.my_data_grid.Visible = false;
            // 
            // btn_save_all_qyesions
            // 
            this.btn_save_all_qyesions.Location = new System.Drawing.Point(26, 64);
            this.btn_save_all_qyesions.Name = "btn_save_all_qyesions";
            this.btn_save_all_qyesions.Size = new System.Drawing.Size(121, 54);
            this.btn_save_all_qyesions.TabIndex = 1;
            this.btn_save_all_qyesions.Text = "Сохранить все вопросы";
            this.btn_save_all_qyesions.UseVisualStyleBackColor = true;
            this.btn_save_all_qyesions.Visible = false;
            this.btn_save_all_qyesions.Click += new System.EventHandler(this.btn_save_all_qyesions_Click);
            // 
            // btn_add_question
            // 
            this.btn_add_question.Location = new System.Drawing.Point(157, 65);
            this.btn_add_question.Name = "btn_add_question";
            this.btn_add_question.Size = new System.Drawing.Size(93, 54);
            this.btn_add_question.TabIndex = 0;
            this.btn_add_question.Text = "Добавить вопрос";
            this.btn_add_question.UseVisualStyleBackColor = true;
            this.btn_add_question.Visible = false;
            this.btn_add_question.Click += new System.EventHandler(this.btn_add_question_Click);
            // 
            // btn_del_qwestion
            // 
            this.btn_del_qwestion.Location = new System.Drawing.Point(276, 64);
            this.btn_del_qwestion.Name = "btn_del_qwestion";
            this.btn_del_qwestion.Size = new System.Drawing.Size(133, 26);
            this.btn_del_qwestion.TabIndex = 9;
            this.btn_del_qwestion.Text = "Удалить вопрос";
            this.btn_del_qwestion.UseVisualStyleBackColor = true;
            this.btn_del_qwestion.Visible = false;
            this.btn_del_qwestion.Click += new System.EventHandler(this.btn_del_qwestion_Click);
            // 
            // txt_id_del_question
            // 
            this.txt_id_del_question.Location = new System.Drawing.Point(276, 96);
            this.txt_id_del_question.Name = "txt_id_del_question";
            this.txt_id_del_question.Size = new System.Drawing.Size(133, 22);
            this.txt_id_del_question.TabIndex = 10;
            this.txt_id_del_question.Visible = false;
            // 
            // Conf_questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 133);
            this.Controls.Add(this.txt_id_del_question);
            this.Controls.Add(this.btn_del_qwestion);
            this.Controls.Add(this.btn_save_all_qyesions);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_add_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.my_data_grid);
            this.Controls.Add(this.txt_id_test);
            this.Controls.Add(this.lbl_id_test);
            this.Controls.Add(this.btn_new_test);
            this.Controls.Add(this.btn_load_test);
            this.Name = "Conf_questions";
            this.Text = "Conf_questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_load_test;
        private System.Windows.Forms.Button btn_new_test;
        private System.Windows.Forms.Label lbl_id_test;
        private System.Windows.Forms.TextBox txt_id_test;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TableLayoutPanel my_data_grid;
        private System.Windows.Forms.Button btn_save_all_qyesions;
        private System.Windows.Forms.Button btn_add_question;
        private System.Windows.Forms.Button btn_del_qwestion;
        private System.Windows.Forms.TextBox txt_id_del_question;
    }
}