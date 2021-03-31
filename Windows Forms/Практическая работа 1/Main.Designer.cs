namespace Практическая_работа_1
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
            this.Input = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(31, 75);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(107, 62);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.input_Click);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(226, 75);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(107, 62);
            this.Calc.TabIndex = 1;
            this.Calc.Text = "Calc";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(31, 195);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(107, 62);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(226, 195);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(107, 62);
            this.About.TabIndex = 3;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(134, 312);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(93, 34);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 371);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Input);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Горбатовский Алексей К3220 Вариант 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
    }
}

