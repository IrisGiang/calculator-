namespace Iris_Calc
{
    partial class Form1
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
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Modulus = new System.Windows.Forms.Button();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(104, 111);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(34, 23);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(45, 111);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(34, 23);
            this.Division.TabIndex = 1;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(45, 12);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(198, 20);
            this.input1.TabIndex = 2;
            this.input1.Text = "1";
            this.input1.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(133, 111);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(34, 23);
            this.Subtraction.TabIndex = 3;
            this.Subtraction.Text = "- ";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Substraction_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(73, 111);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(34, 23);
            this.Addition.TabIndex = 4;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Modulus
            // 
            this.Modulus.Location = new System.Drawing.Point(164, 111);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(34, 23);
            this.Modulus.TabIndex = 5;
            this.Modulus.Text = "%";
            this.Modulus.UseVisualStyleBackColor = true;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(45, 67);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(198, 20);
            this.Input2.TabIndex = 6;
            this.Input2.Text = "2";
            this.Input2.TextChanged += new System.EventHandler(this.Input2_TextChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(42, 187);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Modulus;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
    }
}

