using System;
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
    public partial class EU : Form
    {
        public EU()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextr.Text);
            GV.in_eu[i, 0] = Int32.Parse(m_n1p.Text);
            GV.in_eu[i, 1] = Int32.Parse(m_n1m.Text);
            GV.in_eu[i, 2] = Int32.Parse(m_n2p.Text);
            GV.in_eu[i, 3] = Int32.Parse(m_n2m.Text);
            GV.z_eu[i, 0] = Single.Parse(m_zr.Text);
            GV.z_eu[i, 1] = Single.Parse(m_t1.Text);
            GV.z_eu[i, 2] = Single.Parse(m_t2.Text);
            i++;
            m_nextr.Text = i.ToString();
            if (i <= GV.neu)
            {
                m_n1p.Text = "0";
                m_n2p.Text = "0";
                m_n1m.Text = "0";
                m_n2m.Text = "0";
                m_zr.Text = "0";
                m_t1.Text = "0";
                m_t2.Text = "0";
                m_n1p.Focus();
            }
            else
                this.Close();
        }
    }
}
