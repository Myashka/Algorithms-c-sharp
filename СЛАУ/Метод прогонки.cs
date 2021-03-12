using System;

namespace Метод_прогонки
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте, введите размерность матрицы: ");
            int n = Int32.Parse(Console.ReadLine());
            double[,] A = new double[n, n];
            double[] X = new double[n];
            double[] B = new double[n];
            double[] a = new double[n];
            double[] b = new double[n];
            double[] e = new double[n];
            Console.WriteLine("Введите построчно коэффициенты системы: x1, x2, x3, x(n)");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = double.Parse(Console.ReadLine());
                }

            //вывод матрица A
            Console.WriteLine("\nПолучившаяся матрица A:");
            Show_Boxy_Matrix(A, n);

            Console.WriteLine("\nВведите коэффициенты y1, y2, y3, y(n)");
            for (int i = 0; i < n; i++)
            {
                B[i] = double.Parse(Console.ReadLine());
            }

            //вывод матрица b
            Console.WriteLine("\nПолучившаяся матрица B:");
            Show_One_Matrix_B(B, n);

            // прямой ход прогонки
            e[0] = A[0, 0];
            a[0] = -A[0, 1] / e[0];
            b[0] = B[0] / e[0];
            for (int i = 1; i < n-1; i++)
            {
                if (A[i, i] == 0)
                {
                    Console.WriteLine("Элемент A", i, ',', i, "= 0");
                    Environment.Exit(0);
                }
                e[i] = A[i, i] + A[i, i - 1] * a[i - 1];
                a[i] = -A[i, i + 1] / e[i];
                b[i] = (B[i] - A[i, i - 1] * b[i - 1]) / e[i];
            }
            e[n - 1] = A[n - 1, n - 1] + A[n - 1, n - 2] * a[n - 2];
            b[n - 1] = (B[n - 1] - A[n - 1, n - 2] * b[n - 2]) / e[n - 1];

            //обратный ход прогонки
            X[n - 1] = b[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                X[i] = a[i] * X[i + 1] + b[i];
            }

            Console.WriteLine("\nКорни системы:");
            Show_One_Matrix_X(X, n);
        }


        static void Show_One_Matrix_X(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x[{i}] = {Math.Round(a[i],4)}");

            }
        }
        static void Show_One_Matrix_B(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"B[{i}] = {a[i]}");

            }
        }
        static void Show_Boxy_Matrix(double[,] a, int n)
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
