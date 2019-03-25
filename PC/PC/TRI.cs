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
    public partial class TRI : Form
    {
        public TRI()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextr.Text);
            GV.in_tri[i, 0] = Int32.Parse(m_n1p.Text);
            GV.in_tri[i, 1] = Int32.Parse(m_n1m.Text);
            GV.in_tri[i, 2] = Int32.Parse(m_n2p.Text);
            GV.in_tri[i, 3] = Int32.Parse(m_n2m.Text);
            GV.z_tri[i] = Int32.Parse(m_n.Text);

            i++;
            m_nextr.Text = i.ToString();
            if (i <= GV.ntri)
            {
                m_n1p.Text = "0";
                m_n2p.Text = "0";
                m_n1m.Text = "0";
                m_n2m.Text = "0";
                m_n1p.Focus();
            }
            else
                this.Close();
        }
    }
}
