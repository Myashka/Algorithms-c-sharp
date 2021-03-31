namespace Практическая_работа_1
{
    partial class Conv
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.doButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.result_label = new System.Windows.Forms.Label();
            this.radio_16 = new System.Windows.Forms.RadioButton();
            this.radio_8 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число в десятичной системе исчисления";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(25, 251);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(75, 23);
            this.doButton.TabIndex = 2;
            this.doButton.Text = "Do";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Click += new System.EventHandler(this.doButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(178, 251);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // radio_2
            // 
            this.radio_2.AutoSize = true;
            this.radio_2.Location = new System.Drawing.Point(6, 19);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(31, 17);
            this.radio_2.TabIndex = 7;
            this.radio_2.Text = "2";
            this.radio_2.UseVisualStyleBackColor = true;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(68, 212);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(37, 13);
            this.result_label.TabIndex = 8;
            this.result_label.Text = "Result";
            // 
            // radio_16
            // 
            this.radio_16.AutoSize = true;
            this.radio_16.Location = new System.Drawing.Point(6, 65);
            this.radio_16.Name = "radio_16";
            this.radio_16.Size = new System.Drawing.Size(37, 17);
            this.radio_16.TabIndex = 6;
            this.radio_16.Text = "16";
            this.radio_16.UseVisualStyleBackColor = true;
            // 
            // radio_8
            // 
            this.radio_8.AutoSize = true;
            this.radio_8.Location = new System.Drawing.Point(6, 42);
            this.radio_8.Name = "radio_8";
            this.radio_8.Size = new System.Drawing.Size(31, 17);
            this.radio_8.TabIndex = 5;
            this.radio_8.Text = "8";
            this.radio_8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_2);
            this.groupBox1.Controls.Add(this.radio_8);
            this.groupBox1.Controls.Add(this.radio_16);
            this.groupBox1.Location = new System.Drawing.Point(25, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Система исчисления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ответ:";
            // 
            // Conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.doButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Conv";
            this.Text = "Convert";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton radio_2;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.RadioButton radio_16;
        private System.Windows.Forms.RadioButton radio_8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}