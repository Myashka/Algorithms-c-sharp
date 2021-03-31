using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анализатор_текста
{
    public partial class getLetterForm : Form
    {
        private string letter;
        private string fileText;
        public getLetterForm()
        {
            InitializeComponent();
        }
        public getLetterForm(Main mainForm)
        {
            InitializeComponent();
            fileText = mainForm.getText();
        }
        public string getLetter()
        {
            return letter;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            letter = textBox1.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int letterCount = 0;
            if (letter == null)
            {
                MessageBox.Show("Сперва введите символ.");
                return;
            }
            if (letter.Length != 1)
            {
                MessageBox.Show("Введите один символ.");
                return;
            }
            foreach (var c in fileText.ToLower())
            {
                if (c == letter[0])
                {
                    letterCount++;
                }
            }
            MessageBox.Show("Количество "+ letter + " в тексте: " + letterCount);
            Close();
        }
    }
}
