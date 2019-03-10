namespace PC
{
    partial class IO
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_km = new System.Windows.Forms.TextBox();
            this.m_kp = new System.Windows.Forms.TextBox();
            this.m_lm = new System.Windows.Forms.TextBox();
            this.m_lp = new System.Windows.Forms.TextBox();
            this.IDC_IOOK_BUTTON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "k-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "k+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "l-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "l+";
            // 
            // m_km
            // 
            this.m_km.Location = new System.Drawing.Point(222, 126);
            this.m_km.Name = "m_km";
            this.m_km.Size = new System.Drawing.Size(100, 22);
            this.m_km.TabIndex = 17;
            this.m_km.Text = "0";
            // 
            // m_kp
            // 
            this.m_kp.Location = new System.Drawing.Point(222, 68);
            this.m_kp.Name = "m_kp";
            this.m_kp.Size = new System.Drawing.Size(100, 22);
            this.m_kp.TabIndex = 16;
            this.m_kp.Text = "0";
            // 
            // m_lm
            // 
            this.m_lm.Location = new System.Drawing.Point(26, 126);
            this.m_lm.Name = "m_lm";
            this.m_lm.Size = new System.Drawing.Size(100, 22);
            this.m_lm.TabIndex = 15;
            this.m_lm.Text = "0";
            // 
            // m_lp
            // 
            this.m_lp.Location = new System.Drawing.Point(26, 69);
            this.m_lp.Name = "m_lp";
            this.m_lp.Size = new System.Drawing.Size(100, 22);
            this.m_lp.TabIndex = 14;
            this.m_lp.Text = "0";
            // 
            // IDC_IOOK_BUTTON
            // 
            this.IDC_IOOK_BUTTON.Location = new System.Drawing.Point(174, 215);
            this.IDC_IOOK_BUTTON.Name = "IDC_IOOK_BUTTON";
            this.IDC_IOOK_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_IOOK_BUTTON.TabIndex = 13;
            this.IDC_IOOK_BUTTON.Text = "OK";
            this.IDC_IOOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_IOOK_BUTTON.Click += new System.EventHandler(this.IDC_IOOK_BUTTON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выходные узлы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Входные узлы";
            // 
            // IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 284);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_km);
            this.Controls.Add(this.m_kp);
            this.Controls.Add(this.m_lm);
            this.Controls.Add(this.m_lp);
            this.Controls.Add(this.IDC_IOOK_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IO";
            this.Text = "IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_km;
        private System.Windows.Forms.TextBox m_kp;
        private System.Windows.Forms.TextBox m_lm;
        private System.Windows.Forms.TextBox m_lp;
        private System.Windows.Forms.Button IDC_IOOK_BUTTON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}