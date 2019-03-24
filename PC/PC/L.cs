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
    public partial class L : Form
    {
        public L()
        {
            InitializeComponent();
        }

        private void IDC_NEXTL_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tb_nextl.Text);
            GV.in_l[i, 0] = int.Parse(tb_npl.Text);
            GV.in_l[i, 1] = int.Parse(tb_nml.Text);
            GV.z_l[i] = Single.Parse(tb_zl.Text);
            i++;
            tb_nextl.Text = i.ToString();
            if (i <= GV.nl)
            {
                tb_npl.Text = "0";
                tb_nml.Text = "0";
                tb_zl.Text = "0";
                tb_npl.Focus();
            }
            else
                this.Close();
        }
    }
}
