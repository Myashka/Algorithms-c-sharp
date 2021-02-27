using System;
using System.Collections.Generic;

namespace Метод__Адамса
{
    class Program
    {
        static void Main(string[] args)
        {
            Function F = Func;
            Console.Write("Введите y0: ");
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x0: ");
            double x0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг таблицы: ");
            double h0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэф. дробления шага: ");
            int m = Convert.ToInt32(Console.ReadLine());
            double h = h0 / m;

            List<double> x = new List<double>();
            List<double> y_rk = new List<double>();

            for (double i = x0; i <= h0 + x0; i += h)
            {
                x.Add(Math.Round(i, 3));
                y_rk.Add(Math.Round(y0, 3));
                double y_rk_next = RK_4(Func, i, y0, h);
                y0 = y_rk_next;
            }
            List<double> adams = new List<double>();
            for (int i = 0; i <= 3; i++)
            {
                adams.Add(y_rk[i]);
            }
            for (int i = 4; i < x.Count; i++)
            {
                adams.Add(Math.Round(Adams(x[i - 1], adams[i - 1], x[i - 2], adams[i - 2], x[i - 3], adams[i - 3], x[i - 4], adams[i - 4], h, Func), 3));
            }
            Console.WriteLine("x \n");
            Show(x);
            Console.WriteLine("\nadams \n");
            Show(adams);
            Console.WriteLine("\nrk \n");
            Show(y_rk);
        }

        static double Adams(double x, double y, double x_1,
                double y_1, double x_2, double y_2, double x_3,
                double y_3, double h, Function func)
        {
            double d1_f = func(x, y) - func(x_1, y_1);
            double d2_f = func(x, y) - 2 * func(x_1, y_1) + func(x_2, y_2);
            double d3_f = func(x, y) - 3 * func(x_1, y_1) + 3 * func(x_2, y_2) - func(x_3, y_3);

            return y + (h * y) + (h * h / 2 * d1_f) + (5 / 12 * h * h * h * d2_f) + (3 / 8 * h * h * h * h * d3_f);
        }

        static void Show(List<double> list)
        {
            foreach (var i in list)
            {
                Console.Write(i);
                Console.Write("\t");
            }
        }
        public delegate double Function(double x, double y);

        static double Func(double x, double y)
        {
            return y * Math.Cos(x);
        }
        static double RK_4(Function F, double x0, double y0, double h)
        {
            double k1, k2, k3, k4, yi;
            k1 = h * F(x0, y0);
            k2 = h * F(x0 + h / 2, y0 + k1 / 2);
            k3 = h * F(x0 + h / 2, y0 + k2 / 2);
            k4 = h * F(x0 + h, y0 + k3);
            yi = y0 + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
            return yi;
        }
    }
}
