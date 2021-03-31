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
    public partial class Main : Form
    {
        private getLetterForm newform;
        private string fileText;
        public Main()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadfileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            fileText = System.IO.File.ReadAllText(filename);
            MessageBox.Show("Файл открыт");
        }

        private void wordcountButton_Click(object sender, EventArgs e)
        {
            if (fileText == null)
            {
                MessageBox.Show("Сперва загрузите текстовый файл.");
                return;
            }

            char[] sep = new char[] { ' ', '\r', '\n' };
            int wordsCount = fileText.Split(sep, StringSplitOptions.RemoveEmptyEntries).Length;

            MessageBox.Show("Кол-во слов в тексте: " + wordsCount);
        }
        public string getText()
        {
            return fileText;
        }
        private void lettercountButton_Click(object sender, EventArgs e)
        {
            if (fileText == null)
            {
                MessageBox.Show("Сперва загрузите текстовый файл.");
                return;
            }
            getLetterForm newform = new getLetterForm(this);
            newform.Show();
        }
    }
}
