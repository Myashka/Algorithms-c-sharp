using System;

namespace Рунге_Кутта__4_порядка_
{
    class Program
    {
        public delegate double Function(double x, double y);
        static double[,] RK_4(Function F, double x0, double y0, double h0, int m, ref double[,] arr)
        {
            double h = h0 / m;
            for (int j = 1; j <= m; j++)
            {
                double k1, k2, k3, k4, yi, xi;
                arr[0, j-1] = x0;
                arr[1, j-1] = y0;
                k1 = h * F(x0, y0);
                k2 = h * F(x0 + h / 2, y0 + k1 / 2);
                k3 = h * F(x0 + h / 2, y0 + k2 / 2);
                k4 = h * F(x0 + h, y0 + k3);
                yi = y0 + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                xi = x0 + h;
                x0 = Math.Round(xi, 3);
                y0 = Math.Round(yi, 3);
            }
            return arr;
        }
        static double func(double x, double y)
        {
            return y * Math.Cos(x);
        }
        static void Main(string[] args)
        {
            Function F = func;
            double x0 = 0;
            double y0 = 1;
            double h0 = 1;
            int m = 10;
            double[,] arr = new double[2, m];
            arr = RK_4(F, x0, y0, h0, m, ref arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}