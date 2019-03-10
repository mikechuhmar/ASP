namespace PC
{
    partial class F
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
            this.IDC_FOK_BUTTON = new System.Windows.Forms.Button();
            this.IDC_F3 = new System.Windows.Forms.TextBox();
            this.IDC_F2 = new System.Windows.Forms.TextBox();
            this.IDC_F1 = new System.Windows.Forms.TextBox();
            this.IDC_T3 = new System.Windows.Forms.TextBox();
            this.IDC_T2 = new System.Windows.Forms.TextBox();
            this.IDC_T1 = new System.Windows.Forms.TextBox();
            this.KF = new System.Windows.Forms.RadioButton();
            this.DF = new System.Windows.Forms.RadioButton();
            this.IDC_F = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // IDC_FOK_BUTTON
            // 
            this.IDC_FOK_BUTTON.Location = new System.Drawing.Point(172, 332);
            this.IDC_FOK_BUTTON.Name = "IDC_FOK_BUTTON";
            this.IDC_FOK_BUTTON.Size = new System.Drawing.Size(128, 23);
            this.IDC_FOK_BUTTON.TabIndex = 19;
            this.IDC_FOK_BUTTON.Text = "OK";
            this.IDC_FOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FOK_BUTTON.Click += new System.EventHandler(this.IDC_FOK_BUTTON_Click);
            // 
            // IDC_F3
            // 
            this.IDC_F3.Location = new System.Drawing.Point(307, 275);
            this.IDC_F3.Name = "IDC_F3";
            this.IDC_F3.Size = new System.Drawing.Size(100, 22);
            this.IDC_F3.TabIndex = 18;
            this.IDC_F3.Text = "0";
            // 
            // IDC_F2
            // 
            this.IDC_F2.Location = new System.Drawing.Point(306, 227);
            this.IDC_F2.Name = "IDC_F2";
            this.IDC_F2.Size = new System.Drawing.Size(100, 22);
            this.IDC_F2.TabIndex = 17;
            this.IDC_F2.Text = "0";
            // 
            // IDC_F1
            // 
            this.IDC_F1.Location = new System.Drawing.Point(306, 184);
            this.IDC_F1.Name = "IDC_F1";
            this.IDC_F1.Size = new System.Drawing.Size(100, 22);
            this.IDC_F1.TabIndex = 16;
            this.IDC_F1.Text = "0";
            // 
            // IDC_T3
            // 
            this.IDC_T3.Location = new System.Drawing.Point(36, 274);
            this.IDC_T3.Name = "IDC_T3";
            this.IDC_T3.ReadOnly = true;
            this.IDC_T3.Size = new System.Drawing.Size(219, 22);
            this.IDC_T3.TabIndex = 15;
            // 
            // IDC_T2
            // 
            this.IDC_T2.Location = new System.Drawing.Point(36, 227);
            this.IDC_T2.Name = "IDC_T2";
            this.IDC_T2.ReadOnly = true;
            this.IDC_T2.Size = new System.Drawing.Size(219, 22);
            this.IDC_T2.TabIndex = 14;
            // 
            // IDC_T1
            // 
            this.IDC_T1.Location = new System.Drawing.Point(36, 184);
            this.IDC_T1.Name = "IDC_T1";
            this.IDC_T1.ReadOnly = true;
            this.IDC_T1.Size = new System.Drawing.Size(219, 22);
            this.IDC_T1.TabIndex = 13;
            this.IDC_T1.Text = "Значение частоты (кгц)";
            // 
            // KF
            // 
            this.KF.AutoSize = true;
            this.KF.Location = new System.Drawing.Point(36, 126);
            this.KF.Name = "KF";
            this.KF.Size = new System.Drawing.Size(327, 21);
            this.KF.TabIndex = 12;
            this.KF.Text = "Логарифмический закон изменения частоты";
            this.KF.UseVisualStyleBackColor = true;
            this.KF.CheckedChanged += new System.EventHandler(this.KF_CheckedChanged);
            // 
            // DF
            // 
            this.DF.AutoSize = true;
            this.DF.Location = new System.Drawing.Point(36, 78);
            this.DF.Name = "DF";
            this.DF.Size = new System.Drawing.Size(266, 21);
            this.DF.TabIndex = 11;
            this.DF.Text = "Линйный закон изменения частоты";
            this.DF.UseVisualStyleBackColor = true;
            this.DF.CheckedChanged += new System.EventHandler(this.DF_CheckedChanged);
            // 
            // IDC_F
            // 
            this.IDC_F.AutoSize = true;
            this.IDC_F.Checked = true;
            this.IDC_F.Location = new System.Drawing.Point(36, 34);
            this.IDC_F.Name = "IDC_F";
            this.IDC_F.Size = new System.Drawing.Size(238, 21);
            this.IDC_F.TabIndex = 10;
            this.IDC_F.TabStop = true;
            this.IDC_F.Text = "Единственная частотная точка";
            this.IDC_F.UseVisualStyleBackColor = true;
            this.IDC_F.CheckedChanged += new System.EventHandler(this.IDC_F_CheckedChanged);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 373);
            this.Controls.Add(this.IDC_FOK_BUTTON);
            this.Controls.Add(this.IDC_F3);
            this.Controls.Add(this.IDC_F2);
            this.Controls.Add(this.IDC_F1);
            this.Controls.Add(this.IDC_T3);
            this.Controls.Add(this.IDC_T2);
            this.Controls.Add(this.IDC_T1);
            this.Controls.Add(this.KF);
            this.Controls.Add(this.DF);
            this.Controls.Add(this.IDC_F);
            this.Name = "F";
            this.Text = "F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_FOK_BUTTON;
        private System.Windows.Forms.TextBox IDC_F3;
        private System.Windows.Forms.TextBox IDC_F2;
        private System.Windows.Forms.TextBox IDC_F1;
        private System.Windows.Forms.TextBox IDC_T3;
        private System.Windows.Forms.TextBox IDC_T2;
        private System.Windows.Forms.TextBox IDC_T1;
        private System.Windows.Forms.RadioButton KF;
        private System.Windows.Forms.RadioButton DF;
        private System.Windows.Forms.RadioButton IDC_F;
    }
}