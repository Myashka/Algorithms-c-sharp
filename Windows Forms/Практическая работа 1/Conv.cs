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
    public partial class Conv : Form
    {
        private string inputNumber;
        public Conv()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputNumber = textBox1.Text;
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            bool ava = false;
            try
            {
                number = int.Parse(inputNumber);
                ava = true;
            }
            catch
            {
                MessageBox.Show("Конвертирууемое цисло должно быть целочисленным.");
            }
            if (radio_2.Checked && ava && number > 0)
            {
                result_label.Text = (Convert.ToString(number, 2));
            }
            else if (radio_8.Checked && ava && number > 0)
            {
                result_label.Text = (Convert.ToString(number, 8));
            }
            else if (radio_16.Checked && ava && number > 0)
            {
                result_label.Text = (Convert.ToString(number, 16));
            }
            else
            {
                MessageBox.Show("Необходимо выбрать систему исчисления либо проверить введенные данные.");
            }
        }
    }
}
