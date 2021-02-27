using System;
using System.Collections.Generic;

namespace Метод_последовательных_приближений
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
            for (double i = x0; i <= h0 + x0; i += h)
            {
                x.Add(Math.Round(i, 3));;
            }
            List<double> sequential = new List<double>();
            sequential.Add(y0);
            for (int i = 1; i < x.Count; i++)
            {
                sequential.Add(Math.Round(Sequential(x0, y0, x[i], sequential[i-1], Func), 3));
            }
            Console.WriteLine(sequential[0]);
            Console.WriteLine("x \n");
            Show(x);
            Console.WriteLine("\nSequential \n");
            Show(sequential);
            Console.WriteLine("\nSequential_approximation \n");
            Console.WriteLine(Sequential_approximation(Func, x, sequential, 10, h));



        }
        public static double Integral(Function f, double a, double b, double y, int n)
        {
            double sum = 0.0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                sum += h * f(a + i * h, y);
            }
            return sum;
        }
        public static double Sequential(double x0, double y0, double x, double y, Function func)
        {
            double y1 = y0 + Integral(func, x0, x, y, 100);
            return y0 + Integral(func, x0, x, y1, 100);
        }

        public static double Sequential_approximation(Function func, List<double> x, List<double> y, double n, double h)
        {
            double M = -100000;
            double N = -100000;

            for (int i = 0; i < x.Count; i++)
            {
                double f_value = Math.Abs(func(x[i], y[i]));
                double df_value = Math.Abs(Math.Cos(x[i]));

                if (M < f_value)
                {
                    M = f_value;
                }

                if (N < df_value)
                {
                    N = df_value;
                }
            }

            return Math.Pow(N, n) * M * Math.Pow(h, n + 1) / Factorial(n + 1);
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
            return y* Math.Cos(x);
        }
        static public double Factorial(double numb)
        {
            double res = 1;
            for (double i = numb; i > 1; i--)
                res *= i;
            return res;
        }   
    }
}
