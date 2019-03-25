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
        public static int MJU = 20, MEU = 20, MJI = 20, MEI = 20, MTRI = 20, MOUI = 20, MTR = 20, MTB = 20, MTU = 20, MOU = 20;
        public static int nv, n, nr, nl, nc, neu, nei, ntri, nf, lp, lm, kp, km, k;
        public static int[,] in_r = new int[MR + 1, 2];
        //2 lab
        public static int[,] in_l = new int[ML + 1, 2];
        public static int[,] in_c = new int[MC + 1, 2];
        //3 lab
        public static int[,] in_eu = new int[MEU + 1, 4];
        public static int[,] in_ei = new int[MEI + 1, 4];
        public static int[,] in_tri = new int[MTRI + 1, 4];


        //...
        public static float[] z_r = new float[MR + 1];
        //2 lab
        public static float[] z_l = new float[ML + 1];
        public static float[] z_c = new float[MC + 1];
        // 3lab
        public static float[,] z_eu = new float[MEU + 1, 3];
        public static float[,] z_ei = new float[MEI + 1, 3];
        public static float[] z_tri = new float[MTRI + 1];

        //...
        public static float[] f = new float[MF + 1];
        public static double[,] a = new double[M + 1, M + 1];
        public static double[,] b = new double[M + 1, M + 1];
        public static double om;
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
