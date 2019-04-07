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
    public partial class FrqvsDlg : Form
    {
        public FrqvsDlg()
        {
            InitializeComponent();
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            SIZE size = new SIZE();
            size.ShowDialog(this);
            size.Dispose();
            // операторы вызова диалоговой панели R
            if (GV.nr > 0)
            {
                R ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            //2 лаб
            if (GV.nl > 0)
            {
                L il = new L();
                il.ShowDialog(this);
                il.Dispose();
            }
            if (GV.nc > 0)
            {
                C ic = new C();
                ic.ShowDialog(this);
                ic.Dispose();
            }
            //3 лаб
            if (GV.neu > 0)
            {
                EU ieu = new EU();
                ieu.ShowDialog(this);
                ieu.Dispose();
            }

            if (GV.nei > 0)
            {
                EI iei = new EI();
                iei.ShowDialog(this);
                iei.Dispose();
            }

            if (GV.ntri > 0)
            {
                TRI itri = new TRI();
                itri.ShowDialog(this);
                itri.Dispose();
            }
            //4 lab
            if (GV.nou > 0)
            {
                OU iou = new OU();
                iou.ShowDialog(this);
                iou.Dispose();
            }
            DialogResult res = MessageBox.Show("Выводить описание схемы в файл?",
                "Вывод в файл", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                FILE ofile = new FILE();
                GV.k = 0;
                ofile.ShowDialog(this);
                ofile.Dispose();
            }
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
            OnCalc();
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            GV.k = 1;
            FILE file = new FILE();
            try
            {
                file.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            file.Dispose();
            //… 
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
            OnCalc();
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            RED red = new RED();
            red.ShowDialog(this);
            red.Dispose();
        }

        private void ID_F_Click(object sender, EventArgs e)
        {
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_CALC_Click(object sender, EventArgs e)
        {
            OnCalc();
        }

        private void ID_PRIV_Click(object sender, EventArgs e)
        {
            GV.flag = false;
        }

        private void ID_SYS_Click(object sender, EventArgs e)
        {
            GV.flag = true;
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            if (!GV.flag)
            {
                INT cint = new INT();
                cint.Show(this);
            }
            else
            {
                System.Diagnostics.Process.Start("iexplore.exe", "http://127.0.0.1/MF/Int3d.htm");

            }
        }
        private void OnCalc()
        {

            for (int kf = 1; kf <= GV.nf; kf++)
            {
                GV.s = new Complex(0.0, 2 * 3.141593 * GV.f[kf]);
                //Обнуление массива 
                for (int i = 0; i <= GV.M; i++)
                    for (int j = 0; j <= GV.M; j++)
                    {
                        GV.w[i, j] = new Complex(0, 0);
                    }

                GV.n = GV.nv;

                if (GV.nr != 0)
                    form_d(ref GV.in_r, ref GV.z_r, GV.nr, 'R');
                //2 лаба
                if (GV.nc != 0)
                    form_d(ref GV.in_c, ref GV.z_c, GV.nc, 'C');
                if (GV.nl != 0)
                    form_d(ref GV.in_l, ref GV.z_l, GV.nl,  'L');
                //3 лаба
                if (GV.neu != 0)
                    form_eu();
                if (GV.nei != 0)
                    form_ei();
                if (GV.ntri != 0)
                    form_tri();
                //4 lab
                if (GV.nou != 0)
                    form_ou();
                //...
                form_s();
                if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
                {
                    st();
                    sf1(kf);
                }
                else
                {
                    gauss_c();
                    sf2(kf);
                }
            }
            //Вывод результатов моделирования
            string str = "";
            str = "Результаты моделирования ";
            textBox1.AppendText(str + "\r\n");
            if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
            {
                str = "    f кГц \t kum \t kua \t rim \t ria \t rom \t roa";
                textBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,12:F2}{1,12:E2}{2,12:F2}" +
                        "{3,12:E2}{4,12:F2}{5,12:E2}{6,12:F2}",
                          GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf],
                          GV.ria[kf], GV.rom[kf], GV.roa[kf]);
                    textBox1.AppendText(str + "\r\n");
                }
            }
            else
            {
                str = "    f кГц \t kum \t kua \t rim \t ria";
                textBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,12:F2}{1,12:E2}{2,12:F2}" +
                        "{3,12:E2}{4,12:F2}",
                            GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf], GV.ria[kf]);
                    textBox1.AppendText(str + "\r\n");
                }
            }

            DialogResult res = MessageBox.Show("Выводить результаты в файл?",
                "Вывод результатов", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                write_out();
            MessageBox.Show("Выберите в меню дальнейший режим работы",
                             "Режим работы", MessageBoxButtons.OK);

        }
    }
}
