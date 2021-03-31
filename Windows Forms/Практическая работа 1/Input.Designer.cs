namespace Практическая_работа_1
{
    partial class Input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxPer = new System.Windows.Forms.CheckBox();
            this.CheckBoxArea = new System.Windows.Forms.CheckBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "c:";
            // 
            // CheckBoxPer
            // 
            this.CheckBoxPer.AutoSize = true;
            this.CheckBoxPer.Location = new System.Drawing.Point(35, 158);
            this.CheckBoxPer.Name = "CheckBoxPer";
            this.CheckBoxPer.Size = new System.Drawing.Size(77, 17);
            this.CheckBoxPer.TabIndex = 3;
            this.CheckBoxPer.Text = "Периметр";
            this.CheckBoxPer.UseVisualStyleBackColor = true;
            this.CheckBoxPer.CheckedChanged += new System.EventHandler(this.CheckBoxPer_CheckedChanged);
            // 
            // CheckBoxArea
            // 
            this.CheckBoxArea.AutoSize = true;
            this.CheckBoxArea.Location = new System.Drawing.Point(35, 191);
            this.CheckBoxArea.Name = "CheckBoxArea";
            this.CheckBoxArea.Size = new System.Drawing.Size(73, 17);
            this.CheckBoxArea.TabIndex = 4;
            this.CheckBoxArea.Text = "Площадь";
            this.CheckBoxArea.UseVisualStyleBackColor = true;
            this.CheckBoxArea.CheckedChanged += new System.EventHandler(this.CheckBoxArea_CheckedChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(54, 43);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 5;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(54, 79);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 6;
            this.textBoxB.TextChanged += new System.EventHandler(this.TextBoxB_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(54, 118);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 7;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите стороны треугольника:";
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(67, 234);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 9;
            this.getDataButton.Text = "Ввод";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 281);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.CheckBoxArea);
            this.Controls.Add(this.CheckBoxPer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Input";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.Input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxPer;
        private System.Windows.Forms.CheckBox CheckBoxArea;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getDataButton;
    }
}