using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC
{
    public partial class FILE : Form
    {
        public FILE()
        {
            InitializeComponent();
        }

        private void IDC_FILEOK_BUTTON_Click(object sender, EventArgs e)
        {
            switch (GV.k)
            {
                case 0:
                    GV.filename = m_file.Text;
                    if (GV.filename != "")
                        fileout(GV.filename);
                    else
                        MessageBox.Show("Введите имя файла");
                    break;
                case 1:
                    GV.filename = m_file.Text;
                    try
                    {
                        filein(GV.filename);
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }

                    break;
            }


            this.Close();
        }
        private void filein(String filename)      //Ввод описания схемы из файла
        {
            StreamReader fin = new StreamReader(GV.filename);
            char[] sep = { ' ' };
            string str = "";
            str = fin.ReadLine();
            String[] s = str.Split(sep, 7);//Значение второго аргумента!!!
            GV.nv = Int32.Parse(s[0]);
            GV.nr = Int32.Parse(s[1]);
            GV.nl = Int32.Parse(s[2]);
            GV.nc = Int32.Parse(s[3]);
            GV.neu = Int32.Parse(s[4]);
            GV.nei = Int32.Parse(s[5]);
            GV.ntri = Int32.Parse(s[6]);
            //...
            for (int i = 1; i <= GV.nr; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_r[i, 0] = Int32.Parse(s[0]);
                GV.in_r[i, 1] = Int32.Parse(s[1]);
                GV.z_r[i] = Single.Parse(s[2]);
            }
            //2 lab
            for (int i = 1; i <= GV.nl; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_l[i, 0] = Int32.Parse(s[0]);
                GV.in_l[i, 1] = Int32.Parse(s[1]);
                GV.z_l[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GV.nc; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_c[i, 0] = Int32.Parse(s[0]);
                GV.in_c[i, 1] = Int32.Parse(s[1]);
                GV.z_c[i] = Single.Parse(s[2]);
            }
            //3 lab
            for (int i = 1; i <= GV.neu; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 7);
                GV.in_eu[i, 0] = Int32.Parse(s[0]);
                GV.in_eu[i, 1] = Int32.Parse(s[1]);
                GV.in_eu[i, 2] = Int32.Parse(s[2]);
                GV.in_eu[i, 3] = Int32.Parse(s[3]);
                GV.z_eu[i, 0] = Single.Parse(s[4]);
                GV.z_eu[i, 1] = Single.Parse(s[5]);
                GV.z_eu[i, 2] = Single.Parse(s[6]);
            }
            for (int i = 1; i <= GV.nei; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 7);
                GV.in_ei[i, 0] = Int32.Parse(s[0]);
                GV.in_ei[i, 1] = Int32.Parse(s[1]);
                GV.in_ei[i, 2] = Int32.Parse(s[2]);
                GV.in_ei[i, 3] = Int32.Parse(s[3]);
                GV.z_ei[i, 0] = Single.Parse(s[4]);
                GV.z_ei[i, 1] = Single.Parse(s[5]);
                GV.z_ei[i, 2] = Single.Parse(s[6]);
            }
            for (int i = 1; i <= GV.ntri; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 5);
                GV.in_tri[i, 0] = Int32.Parse(s[0]);
                GV.in_tri[i, 1] = Int32.Parse(s[1]);
                GV.in_tri[i, 2] = Int32.Parse(s[2]);
                GV.in_tri[i, 3] = Int32.Parse(s[3]);
                GV.z_tri[i] = Single.Parse(s[4]);

            }
            //...
            fin.Close();

        }


        private void fileout(String filename)      //Вывод описания схемы в файл
        {
            StreamWriter fout = new StreamWriter(GV.filename);
            String str = "";
            int i;
            str = GV.nv.ToString() + " " + GV.nr.ToString() + " " + GV.nl.ToString() + " " + GV.nc.ToString() + " "
                + GV.neu.ToString() + " " + GV.nei.ToString() + " " + GV.ntri.ToString();

            fout.WriteLine(str);
            for (i = 1; i <= GV.nr; i++)
            {
                str = GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " "
                    + GV.z_r[i].ToString();
                fout.WriteLine(str);

            }
            //2 lab
            for (i = 1; i <= GV.nl; i++)
            {
                str = GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " "
                    + GV.z_l[i].ToString();
                fout.WriteLine(str);

            }
            for (i = 1; i <= GV.nc; i++)
            {
                str = GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " "
                    + GV.z_c[i].ToString();
                fout.WriteLine(str);

            }
            //3 lab
            for (i = 1; i <= GV.neu; i++)
            {
                str = GV.in_eu[i, 0].ToString() + " " + GV.in_eu[i, 1].ToString() + " "
                    + GV.in_eu[i, 2].ToString() + " " + GV.in_eu[i, 3].ToString() + " "
                    + GV.z_eu[i, 0].ToString() + " " + GV.z_eu[i, 1].ToString() + " " + GV.z_eu[i, 2].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.nei; i++)
            {
                str = GV.in_ei[i, 0].ToString() + " " + GV.in_ei[i, 1].ToString() + " "
                    + GV.in_ei[i, 2].ToString() + " " + GV.in_ei[i, 3].ToString() + " "
                    + GV.z_ei[i, 0].ToString() + " " + GV.z_ei[i, 1].ToString() + " " + GV.z_ei[i, 2].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.ntri; i++)
            {
                str = GV.in_tri[i, 0].ToString() + " " + GV.in_tri[i, 1].ToString() + " "
                    + GV.in_tri[i, 2].ToString() + " " + GV.in_tri[i, 3].ToString() + " "
                    + GV.z_tri[i].ToString();
                fout.WriteLine(str);
            }

            fout.Close();

        }
    }
}
