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
    public partial class OU : Form
    {
        public OU()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextou.Text);
            GV.in_ou[i, 1] = Int32.Parse(m_npou1.Text);
            GV.in_ou[i, 2] = Int32.Parse(m_nmou1.Text);
            GV.in_ou[i, 3] = Int32.Parse(m_npou2.Text);
            GV.in_ou[i, 4] = Int32.Parse(m_nmou2.Text);
            GV.z_ou[i, 0] = Single.Parse(m_ri.Text);
            GV.z_ou[i, 1] = Single.Parse(m_ro.Text);
            GV.z_ou[i, 2] = Single.Parse(m_mu.Text);
            GV.z_ou[i, 3] = Single.Parse(m_ft.Text);
            i++;
            m_nextou.Text = i.ToString();
            if (i <= GV.nou)
            {
                m_npou1.Text = "0";
                m_nmou1.Text = "0";
                m_npou2.Text = "0";
                m_nmou2.Text = "0";
                m_npou1.Focus();
            }
            else
                this.Close();
        }
    }
}
