﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC
{
    public partial class RED : Form
    {
        public RED()
        {
            InitializeComponent();
        }

        private void m_redlst_DoubleClick(object sender, EventArgs e)
        {
            String i1, i2, i3, i4, i5, i6, i7, i8, i9;

            //Начальная установка

            ///////////

            int idx = m_redlst.SelectedIndex;
            switch (idx)
            {
                case 0:
                case 1:
                case 2:
                    i1 = "n+";
                    i2 = "n-";
                    i3 = "Значение";
                    IDC_NP2_STATIC.Text = i1;
                    IDC_NM2_STATIC.Text = i2;
                    IDC_Z1_STATIC.Text = i3;
                    m_np1.Hide();
                    m_nm1.Hide();
                    m_z2.Hide();
                    m_z3.Hide();
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    IDC_NP1_STATIC.Hide();
                    IDC_NM1_STATIC.Hide();
                    IDC_Z2_STATIC.Hide();
                    IDC_Z3_STATIC.Hide();
                    IDC_Z4_STATIC.Hide();
                    IDC_Z5_STATIC.Hide();
                    IDC_Z6_STATIC.Hide();
                    m_n.Focus();
                    break;
            }
        }

        private void IDC_OUT_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;
            GV.k = Int32.Parse(m_n.Text);

            switch (idx)
            {
                case 0:
                    m_np2.Text = GV.in_r[GV.k, 0].ToString();
                    m_nm2.Text = GV.in_r[GV.k, 1].ToString();
                    m_z1.Text = GV.z_r[GV.k].ToString();
                    break;
                    //...
               
            }
            OK.Focus();
        }

        private void IDC_IN_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;
            switch (idx)
            {
                case 0:
                    GV.in_r[GV.k, 0] = Int32.Parse(m_np2.Text);
                    GV.in_r[GV.k, 1] = Int32.Parse(m_nm2.Text);
                    GV.z_r[GV.k] = Single.Parse(m_z1.Text);
                    break;
                    //...
            }
            OK.Focus();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
