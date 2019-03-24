namespace PC
{
    partial class SIZE
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
            this.OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_nr = new System.Windows.Forms.TextBox();
            this.m_nv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_nl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_nc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(237, 257);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(234, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Резисторы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(231, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число узлов";
            // 
            // m_nr
            // 
            this.m_nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_nr.Location = new System.Drawing.Point(45, 98);
            this.m_nr.Name = "m_nr";
            this.m_nr.Size = new System.Drawing.Size(100, 22);
            this.m_nr.TabIndex = 6;
            this.m_nr.Text = "0";
            // 
            // m_nv
            // 
            this.m_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_nv.Location = new System.Drawing.Point(45, 57);
            this.m_nv.Name = "m_nv";
            this.m_nv.Size = new System.Drawing.Size(100, 22);
            this.m_nv.TabIndex = 5;
            this.m_nv.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(233, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Индуктивности";
            // 
            // m_nl
            // 
            this.m_nl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_nl.Location = new System.Drawing.Point(45, 173);
            this.m_nl.Name = "m_nl";
            this.m_nl.Size = new System.Drawing.Size(100, 22);
            this.m_nl.TabIndex = 12;
            this.m_nl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(233, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Конденсаторы";
            // 
            // m_nc
            // 
            this.m_nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_nc.Location = new System.Drawing.Point(45, 140);
            this.m_nc.Name = "m_nc";
            this.m_nc.Size = new System.Drawing.Size(100, 22);
            this.m_nc.TabIndex = 10;
            this.m_nc.Text = "0";
            // 
            // SIZE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_nl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_nc);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_nr);
            this.Controls.Add(this.m_nv);
            this.Name = "SIZE";
            this.Text = "SIZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_nr;
        private System.Windows.Forms.TextBox m_nv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_nl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_nc;
    }
}