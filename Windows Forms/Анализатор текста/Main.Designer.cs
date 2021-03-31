namespace Анализатор_текста
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordcountButton = new System.Windows.Forms.Button();
            this.lettercountButton = new System.Windows.Forms.Button();
            this.loadfileButton = new System.Windows.Forms.Button();
            this.exitButtom = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordcountButton
            // 
            this.wordcountButton.Location = new System.Drawing.Point(44, 140);
            this.wordcountButton.Name = "wordcountButton";
            this.wordcountButton.Size = new System.Drawing.Size(100, 46);
            this.wordcountButton.TabIndex = 0;
            this.wordcountButton.Text = "Количество слов";
            this.wordcountButton.UseVisualStyleBackColor = true;
            this.wordcountButton.Click += new System.EventHandler(this.wordcountButton_Click);
            // 
            // lettercountButton
            // 
            this.lettercountButton.Location = new System.Drawing.Point(223, 140);
            this.lettercountButton.Name = "lettercountButton";
            this.lettercountButton.Size = new System.Drawing.Size(99, 46);
            this.lettercountButton.TabIndex = 1;
            this.lettercountButton.Text = "Повторяемость букв";
            this.lettercountButton.UseVisualStyleBackColor = true;
            this.lettercountButton.Click += new System.EventHandler(this.lettercountButton_Click);
            // 
            // loadfileButton
            // 
            this.loadfileButton.Location = new System.Drawing.Point(44, 38);
            this.loadfileButton.Name = "loadfileButton";
            this.loadfileButton.Size = new System.Drawing.Size(100, 46);
            this.loadfileButton.TabIndex = 2;
            this.loadfileButton.Text = "Загрузить текст";
            this.loadfileButton.UseVisualStyleBackColor = true;
            this.loadfileButton.Click += new System.EventHandler(this.loadfileButton_Click);
            // 
            // exitButtom
            // 
            this.exitButtom.Location = new System.Drawing.Point(223, 38);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(99, 46);
            this.exitButtom.TabIndex = 3;
            this.exitButtom.Text = "Exit";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Анализ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButtom);
            this.Controls.Add(this.loadfileButton);
            this.Controls.Add(this.lettercountButton);
            this.Controls.Add(this.wordcountButton);
            this.Name = "Main";
            this.Text = "Анализоатор текста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wordcountButton;
        private System.Windows.Forms.Button lettercountButton;
        private System.Windows.Forms.Button loadfileButton;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

