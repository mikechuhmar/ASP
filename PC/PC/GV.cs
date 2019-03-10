using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    class GV
    {
        public static int M = 100, MR = 50, MC = 50, ML = 20, MF = 20;
        public static int nv, n, nr, nf, lp, lm, kp, km, k;
        public static int[,] in_r = new int[MR + 1, 2];
        //...
        public static float[] z_r = new float[MR + 1];
        //...
        public static float[] f = new float[MF + 1];
        public static Complex s;
        public static Complex[,] w = new Complex[M + 1, M + 1];
        public static float[] kum = new float[MF + 1];
        public static float[] kua = new float[MF + 1];
        public static float[] rim = new float[MF + 1];
        public static float[] ria = new float[MF + 1];
        public static float[] rom = new float[MF + 1];
        public static float[] roa = new float[MF + 1];
        public static String filename;
        public static bool flag = false;
    }
}
