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
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void IDC_NEXTC_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tb_nextс.Text);
            GV.in_c[i, 0] = int.Parse(tb_npс.Text);
            GV.in_c[i, 1] = int.Parse(tb_nmс.Text);
            GV.z_c[i] = Single.Parse(tb_zс.Text);
            i++;
            tb_nextс.Text = i.ToString();
            if (i <= GV.nc)
            {
                tb_npс.Text = "0";
                tb_nmс.Text = "0";
                tb_zс.Text = "0";
                tb_npс.Focus();
            }
            else
                this.Close();
        }
    }
}
