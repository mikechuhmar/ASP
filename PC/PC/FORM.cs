using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public partial class FrqvsDlg
    {
        void form_d(ref int[,] in_d, ref float[] z_d, int nd, char td)
        {
            int i, j, g;
            for (int kd = 1; kd <= nd; kd++)
                for (int l = 0; l <= 1; l++)
                {
                    i = in_d[kd, l];
                    if (i == 0) continue;
                    for (int m = 0; m <= 1; m++)
                    {
                        j = in_d[kd, m];
                        if (j == 0) continue;
                        g = (1 - 2 * l) * (1 - 2 * m);
                        switch (td)
                        {
                            case 'R': GV.w[i, j] += g / z_d[kd]; break;
                            case 'C': GV.w[i, j] += g * GV.s * z_d[kd]; break;
                            case 'L': GV.w[i, j] += g / (GV.s * z_d[kd]); break;

                        }
                    }
                }
        }


        private void form_s()
        {
            for (int i = 1; i <= GV.n; i++)
                GV.w[i, 0] = new Complex(0, 0);
            if (GV.lp != 0)
                GV.w[GV.lp, 0] = new Complex(-1, 0);
            if (GV.lm != 0)
                GV.w[GV.lm, 0] = new Complex(1, 0);
        }

        private void form_w()
        {
            int i, j;
            double t;
            for (i = 1; i <= GV.n; i++)
                for (j = 1; j <= GV.n; j++)
                {
                    t = GV.b[i, j];
                    if (t != 0)
                        t *= GV.om;
                    GV.w[i, j] = new Complex(GV.a[i, j], t);
                }
        }

        //Формирование комплексных частных матриц частотно-зависимых ИНУН
        void form_eu()
        {
            Complex ms = new Complex(0, 0);
            int i, j, g;
            for (int keu = 1; keu <= GV.neu; keu++)
            {
                ms = GV.z_eu[keu, 0] * (1 + GV.s * GV.z_eu[keu, 1]) / (1+ GV.s * GV.z_eu[keu, 2]);
                i = GV.n + keu;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_eu[keu, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * ms;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.neu;
        }
        //Формирование комплексных частных матриц частотно-зависимых ИНУТ
        void form_ei()
        {
            Complex ms = new Complex(0, 0);
            int i1, i2, j, g;
            for (int kei = 1; kei <= GV.nei; kei++)
            {
                ms = GV.z_ei[kei, 0] * (1 + GV.s * GV.z_eu[kei, 1]) / (1 + GV.s * GV.z_eu[kei, 2]);
                i1 = GV.n + kei;
                i2 = i1 + GV.nei;
                GV.w[i2, i1] = ms;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_ei[kei, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i1, j] -= g;
                        GV.w[j, i1] += g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i2, j] -= g;
                        GV.w[j, i2] += g;
                    }
                }
            }
            GV.n += 2 * GV.nei;
        }









        //Формирование комплексных частных матриц идеального трансформатора
        void form_tri()
        {
            int i, j, g;
            for (int ktri = 1; ktri <= GV.ntri; ktri++)
            {
                i = GV.n + ktri;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_tri[ktri, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * GV.z_tri[ktri];
                        GV.w[j, i] -= g * GV.z_tri[ktri];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.ntri;
        }

        void form_ou()
        {
            Complex cn = new Complex(0, 0);
            Complex[,] y = new Complex[5, 5];
            Complex ys = new Complex(0, 0);
            int[,] in_d = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[] in_ju = new int[4] { 1, 2, 4, 3 };
            int i, j, g, ii, jj, l, m;
            for (int kou = 1; kou <= GV.nou; kou++)
            {
                for (i = 1; i <= 4; i++)
                    for (j = 1; j <= 4; j++)
                        y[i, j] = cn;
                for (int k = 0; k <= 1; k++)
                    for (l = 0; l <= 1; l++)
                    {
                        i = in_d[k, l];
                        for (m = 0; m <= 1; m++)
                        {
                            j = in_d[k, m];
                            g = (1 - 2 * l) * (1 - 2 * m);
                            y[i, j] += g / GV.z_ou[kou, k];
                        }
                    }
                ys = GV.z_ou[kou, 2] / (1 + GV.s * 0.16 * GV.z_ou[kou, 2] /
                               GV.z_ou[kou, 3]) / GV.z_ou[kou, 1];
                for (l = 2; l <= 3; l++)
                {
                    i = in_ju[l];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_ju[m];
                        g = (1 - 2 * m) * (5 - 2 * l);
                        y[i, j] += g * ys;
                    }
                }
                for (i = 1; i <= 4; i++)
                {
                    ii = GV.in_ou[kou, i];
                    if (ii == 0) continue;
                    for (j = 1; j <= 4; j++)
                    {
                        jj = GV.in_ou[kou, j];
                        if (jj == 0) continue;
                        GV.w[ii, jj] += y[i, j];
                    }
                }
            }
        }

    }
}
