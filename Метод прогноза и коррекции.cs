using System;
using System.Collections.Generic;


namespace Метод_прогноза_и_коррекции
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
            double h = h0/m;

            List<double> x = new List<double>();
            List<double> y_rk = new List<double>();

            for (double i =x0; i <= h0+x0; i +=h)
            {
                x.Add(Math.Round(i, 3));
                y_rk.Add(Math.Round(y0, 3));
                double y_rk_next = RK_4(Func,i, y0,h);
                y0 = y_rk_next;
            }
            List<double> predictor = new List<double>();
            List<double> corrector = new List<double>();
            for (int i=0; i <= 3; i++)
            {
                predictor.Add(y_rk[i]);
                corrector.Add(y_rk[i]);
            }
            for (int i = 4; i < x.Count; i++)
            {
                predictor.Add(Math.Round(Predictor(x[i - 1], predictor[i - 1], h, x[i-2], predictor[i-2],x[i-3],predictor[i-3],x[i-4], predictor[i-4], Func), 3));
                corrector.Add(Math.Round(Corrector(x[i], predictor[i], h, x[i - 1], predictor[i - 1], x[i - 2], predictor[i - 2], x[i - 3], predictor[i - 3], Func), 3));

            }
            Console.WriteLine("x \n");
            Show(x);
            Console.WriteLine("\n predictor \n");
            Show(predictor);
            Console.WriteLine("\n corretcor \n");
            Show(corrector);
            Console.WriteLine("\n rk \n");
            Show(y_rk);
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
        static double Predictor(double x, double y, double h, double x_2,
                 double y_2, double x_3, double y_3,
                 double x_4, double y_4, Function func)
        {
            return y + h / 24 * (55 * func(x, y) - 59 * func(x_2, y_2) + 37 * func(x_3, y_3) - 9 * func(x_4, y_4));
        }
        static double Corrector(double x_plus1, double y_plus1, double h,
                 double x, double y, double x_1, double y_1,
                 double x_2, double y_2, Function func)
        {
            return y + h / 24 * (9 * func(x_plus1, y_plus1) - 19 * func(x, y) - 5 * func(x_1, y_1) + func(x_2, y_2));
        }
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
