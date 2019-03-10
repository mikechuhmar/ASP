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
                                //...
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
    }
}
