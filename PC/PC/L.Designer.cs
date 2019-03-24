namespace PC
{
    partial class L
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
            this.IDC_NEXTL_BUTTON = new System.Windows.Forms.Button();
            this.tb_nml = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_npl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_zl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nextl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTL_BUTTON
            // 
            this.IDC_NEXTL_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDC_NEXTL_BUTTON.Location = new System.Drawing.Point(112, 226);
            this.IDC_NEXTL_BUTTON.Name = "IDC_NEXTL_BUTTON";
            this.IDC_NEXTL_BUTTON.Size = new System.Drawing.Size(141, 32);
            this.IDC_NEXTL_BUTTON.TabIndex = 26;
            this.IDC_NEXTL_BUTTON.Text = "Следующий";
            this.IDC_NEXTL_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTL_BUTTON.Click += new System.EventHandler(this.IDC_NEXTL_BUTTON_Click);
            // 
            // tb_nml
            // 
            this.tb_nml.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nml.Location = new System.Drawing.Point(252, 122);
            this.tb_nml.Name = "tb_nml";
            this.tb_nml.Size = new System.Drawing.Size(83, 22);
            this.tb_nml.TabIndex = 25;
            this.tb_nml.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Узел n-";
            // 
            // tb_npl
            // 
            this.tb_npl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_npl.Location = new System.Drawing.Point(252, 81);
            this.tb_npl.Name = "tb_npl";
            this.tb_npl.Size = new System.Drawing.Size(83, 22);
            this.tb_npl.TabIndex = 23;
            this.tb_npl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Узел n+";
            // 
            // tb_zl
            // 
            this.tb_zl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_zl.Location = new System.Drawing.Point(252, 163);
            this.tb_zl.Name = "tb_zl";
            this.tb_zl.Size = new System.Drawing.Size(83, 22);
            this.tb_zl.TabIndex = 21;
            this.tb_zl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Индуктивность (Гн)";
            // 
            // tb_nextl
            // 
            this.tb_nextl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nextl.Location = new System.Drawing.Point(252, 42);
            this.tb_nextl.Name = "tb_nextl";
            this.tb_nextl.ReadOnly = true;
            this.tb_nextl.Size = new System.Drawing.Size(83, 22);
            this.tb_nextl.TabIndex = 19;
            this.tb_nextl.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Индуктивность L";
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 271);
            this.Controls.Add(this.IDC_NEXTL_BUTTON);
            this.Controls.Add(this.tb_nml);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_npl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_zl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nextl);
            this.Controls.Add(this.label1);
            this.Name = "L";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTL_BUTTON;
        private System.Windows.Forms.TextBox tb_nml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_npl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_zl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nextl;
        private System.Windows.Forms.Label label1;
    }
}