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
    public partial class Input : Form
    {
        private string stringA;
        private string stringB;
        private string stringC;

        private double A;
        private double B;
        private double C;

        private bool doPerimetre;
        private bool doArea;
        private bool availabToDo = false;
        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e) { }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            stringA = textBoxA.Text;
        }

        private void TextBoxB_TextChanged(object sender, EventArgs e)
        {
            stringB = textBoxB.Text;
        }
        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            stringC = textBoxC.Text;
        }
        private void CheckBoxPer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            doPerimetre = checkBox.Checked;
        }

        private void CheckBoxArea_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox checkBox = (CheckBox)sender;
            doArea = checkBox.Checked;
        }
        public bool getAvailabToDo()
        {
            return availabToDo;
        }
        public bool getPerimetre()
        {
            return doPerimetre;
        }
        public bool getCalcSquare()
        {
            return doArea;
        }
        public double getTriangleA()
        {
            return A;
        }
        public double getTriangleB()
        {
            return B;
        }
        public double getTriangleC()
        {
            return C;
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            double doubleA = 0;
            double doubleB = 0;
            double doubleC = 0;
            try
            {
                doubleA = double.Parse(stringA);
                doubleB = double.Parse(stringB);
                doubleC = double.Parse(stringC);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные.");
            }
            
            if ((doubleA > 0 && doubleB > 0 && doubleC > 0) &&
                (doubleA + doubleB > doubleC
                && doubleA + doubleC > doubleB
                && doubleB + doubleC > doubleA) &&
                (doPerimetre || doArea))
            {
                availabToDo = true;
                A = doubleA;
                B = doubleB;
                C = doubleC;
                MessageBox.Show("Ввод данных прошел успешно.");
                Close();
            }
            else if (!(doPerimetre || doArea))
            {
                MessageBox.Show("Выберите хотя бы один из расчетных параметров.");
            }
            else if ((doubleA <= 0 || doubleB <= 0 || doubleC <= 0) ||
                (doubleA + doubleB <= doubleC)
                || (doubleA + doubleC <= doubleB)
                || (doubleB + doubleC <= doubleA))
            {
                MessageBox.Show("Треугольника с такими сторонами не существует.");
            }
        }
    }
}
