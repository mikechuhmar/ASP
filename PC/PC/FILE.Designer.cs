namespace PC
{
    partial class FILE
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
            this.IDC_FILEOK_BUTTON = new System.Windows.Forms.Button();
            this.m_file = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_FILEOK_BUTTON
            // 
            this.IDC_FILEOK_BUTTON.Location = new System.Drawing.Point(103, 185);
            this.IDC_FILEOK_BUTTON.Name = "IDC_FILEOK_BUTTON";
            this.IDC_FILEOK_BUTTON.Size = new System.Drawing.Size(109, 23);
            this.IDC_FILEOK_BUTTON.TabIndex = 5;
            this.IDC_FILEOK_BUTTON.Text = "OK";
            this.IDC_FILEOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FILEOK_BUTTON.Click += new System.EventHandler(this.IDC_FILEOK_BUTTON_Click);
            // 
            // m_file
            // 
            this.m_file.Location = new System.Drawing.Point(52, 103);
            this.m_file.Name = "m_file";
            this.m_file.Size = new System.Drawing.Size(234, 22);
            this.m_file.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите имя файла";
            // 
            // FILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 239);
            this.Controls.Add(this.IDC_FILEOK_BUTTON);
            this.Controls.Add(this.m_file);
            this.Controls.Add(this.label1);
            this.Name = "FILE";
            this.Text = "FILE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_FILEOK_BUTTON;
        private System.Windows.Forms.TextBox m_file;
        private System.Windows.Forms.Label label1;
    }
}