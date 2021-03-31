using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_1
{
    public partial class Main : Form
    {
        private Input input;
        public Main()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void input_Click(object sender, EventArgs e)
        {
            input = new Input();
            input.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Написать разработчику: porsh-5@yandex.ru" +
                "    \nГитхаб разработчика:https://github.com/Myashka/Algorithms-c-sharp");
        }
        public double Perimetre(double a, double b, double c)
        {
            return a + b + c;
        }
        public double Area(double a, double b, double c)
        {
            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (input.getAvailabToDo())
            {
                string answer ="";
                double a = input.getTriangleA();
                double b = input.getTriangleB();
                double c = input.getTriangleC();
                if (input.getPerimetre())
                {
                    answer += "Периметр введенного теругольника: " + Perimetre(a, b, c) + "\n";
                }
                if (input.getPerimetre())
                {
                    answer += "Площадь введенного теругольника: " + Area(a, b, c) + "\n";
                }
                MessageBox.Show(answer);
            }
            else
            {
                MessageBox.Show("Проверьте данные в input.");
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Conv conv = new Conv();
            conv.Show();
        }
    }
}
