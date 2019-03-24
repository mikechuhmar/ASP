namespace PC
{
    partial class C
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
            this.IDC_NEXTC_BUTTON = new System.Windows.Forms.Button();
            this.tb_nmс = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_npс = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_zс = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nextс = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTC_BUTTON
            // 
            this.IDC_NEXTC_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDC_NEXTC_BUTTON.Location = new System.Drawing.Point(107, 208);
            this.IDC_NEXTC_BUTTON.Name = "IDC_NEXTC_BUTTON";
            this.IDC_NEXTC_BUTTON.Size = new System.Drawing.Size(141, 32);
            this.IDC_NEXTC_BUTTON.TabIndex = 26;
            this.IDC_NEXTC_BUTTON.Text = "Следующий";
            this.IDC_NEXTC_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTC_BUTTON.Click += new System.EventHandler(this.IDC_NEXTC_BUTTON_Click);
            // 
            // tb_nmс
            // 
            this.tb_nmс.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nmс.Location = new System.Drawing.Point(246, 108);
            this.tb_nmс.Name = "tb_nmс";
            this.tb_nmс.Size = new System.Drawing.Size(83, 22);
            this.tb_nmс.TabIndex = 25;
            this.tb_nmс.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Узел n-";
            // 
            // tb_npс
            // 
            this.tb_npс.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_npс.Location = new System.Drawing.Point(246, 67);
            this.tb_npс.Name = "tb_npс";
            this.tb_npс.Size = new System.Drawing.Size(83, 22);
            this.tb_npс.TabIndex = 23;
            this.tb_npс.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Узел n+";
            // 
            // tb_zс
            // 
            this.tb_zс.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_zс.Location = new System.Drawing.Point(246, 149);
            this.tb_zс.Name = "tb_zс";
            this.tb_zс.Size = new System.Drawing.Size(83, 22);
            this.tb_zс.TabIndex = 21;
            this.tb_zс.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ёмкость (Ф)";
            // 
            // tb_nextс
            // 
            this.tb_nextс.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nextс.Location = new System.Drawing.Point(246, 28);
            this.tb_nextс.Name = "tb_nextс";
            this.tb_nextс.ReadOnly = true;
            this.tb_nextс.Size = new System.Drawing.Size(83, 22);
            this.tb_nextс.TabIndex = 19;
            this.tb_nextс.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Конденсатор C";
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 269);
            this.Controls.Add(this.IDC_NEXTC_BUTTON);
            this.Controls.Add(this.tb_nmс);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_npс);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_zс);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nextс);
            this.Controls.Add(this.label1);
            this.Name = "C";
            this.Text = "C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTC_BUTTON;
        private System.Windows.Forms.TextBox tb_nmс;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_npс;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_zс;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nextс;
        private System.Windows.Forms.Label label1;
    }
}