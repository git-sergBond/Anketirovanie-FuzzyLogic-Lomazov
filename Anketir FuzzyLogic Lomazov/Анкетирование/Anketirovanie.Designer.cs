namespace Анкетирование
{
    partial class Anketirovanie
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
            this.bt_save_result = new System.Windows.Forms.Button();
            this.btdown_quest = new System.Windows.Forms.Button();
            this.id_test = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_save_result
            // 
            this.bt_save_result.Location = new System.Drawing.Point(133, 487);
            this.bt_save_result.Name = "bt_save_result";
            this.bt_save_result.Size = new System.Drawing.Size(282, 50);
            this.bt_save_result.TabIndex = 0;
            this.bt_save_result.Text = "сохранить результат";
            this.bt_save_result.UseVisualStyleBackColor = true;
            this.bt_save_result.Click += new System.EventHandler(this.bt_save_result_clk);
            // 
            // btdown_quest
            // 
            this.btdown_quest.Location = new System.Drawing.Point(317, 12);
            this.btdown_quest.Name = "btdown_quest";
            this.btdown_quest.Size = new System.Drawing.Size(98, 37);
            this.btdown_quest.TabIndex = 19;
            this.btdown_quest.Text = "загрузить тест";
            this.btdown_quest.UseVisualStyleBackColor = true;
            this.btdown_quest.Click += new System.EventHandler(this.btdown_quest_Click);
            // 
            // id_test
            // 
            this.id_test.Cursor = System.Windows.Forms.Cursors.Cross;
            this.id_test.Location = new System.Drawing.Point(238, 21);
            this.id_test.Name = "id_test";
            this.id_test.Size = new System.Drawing.Size(52, 20);
            this.id_test.TabIndex = 20;
            this.id_test.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введи ID теста";
            // 
            // Anketirovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_test);
            this.Controls.Add(this.btdown_quest);
            this.Controls.Add(this.bt_save_result);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Anketirovanie";
            this.Text = "Anketirovanie";
            this.Load += new System.EventHandler(this.Anketirovanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_save_result;
        private System.Windows.Forms.Button btdown_quest;
        private System.Windows.Forms.TextBox id_test;
        private System.Windows.Forms.Label label1;
    }
}