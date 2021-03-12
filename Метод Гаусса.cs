using System;

namespace Метод_Гаусса
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте, введите размерность матрицы: ");
            double s, d;
            int n = Int32.Parse(Console.ReadLine());
            double[,] a = new double[n, n];
            double[] x = new double[n];
            double[] b = new double[n];

            Console.WriteLine("Введите построчно коэффициенты системы: x1, x2, x3, x(n)");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("\n", a.Length);
            //вывод матрица A
            Console.WriteLine("\nПолучившаяся матрица A:");
            Show_Boxy_Matrix(a, n);
            Console.WriteLine("\nВведите коэффициенты y1, y2, y3, y(n)");
            for (int i = 0; i < n; i++)
            {
                b[i] = double.Parse(Console.ReadLine());
            }
            //вывод матрица b
            Console.WriteLine("\nПолучившаяся матрица B:");
            Show_One_Matrix_B(b, n);

            // прямой ход метода Гаусса 
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    d = a[i, k] / a[k, k];
                    for (int j = k; j < n; j++)
                    {
                        a[i, j] = a[i, j] - a[k, j] * d;
                    }
                    b[i] = b[i] - b[k] * d;
                }
            }

            //вывод матрица A после преобразований
            Console.WriteLine("\nМатрица A после приведения к ступенчатому виду:");
            Show_Boxy_Matrix(a, n);
            Console.WriteLine("\nМатрица B после прямого хода:");
            Show_One_Matrix_B(b, n);

            //обратный ход
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int i = k; i <= n-1; i++)
                {
                    s += a[k, i] * x[i];
                }
                if (a[k,k] == 0)
                {
                    Console.WriteLine("Элемент A", k, ',', k, "= 0");
                    Environment.Exit(0);
                }
                x[k] = (b[k] - s)/a[k,k];
            }
            Console.WriteLine("\nКорни системы:");
            Show_One_Matrix_X(x, n);
        }


        static void Show_One_Matrix_X(double [] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x[{i}] = {a[i]}");

            }
        }
        static void Show_One_Matrix_B(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"B[{i}] = {a[i]}");

            }
        }
        static void Show_Boxy_Matrix(double [,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
