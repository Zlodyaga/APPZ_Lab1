namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            coloredNumberTextBox1 = new WinFormsControlLibrary1.ColoredNumberTextBox();
            coloredNumberTextBox2 = new WinFormsControlLibrary1.ColoredNumberTextBox();
            coloredNumberTextBox3 = new WinFormsControlLibrary1.ColoredNumberTextBox();
            SuspendLayout();
            // 
            // coloredNumberTextBox1
            // 
            coloredNumberTextBox1.BackColor = Color.White;
            coloredNumberTextBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            coloredNumberTextBox1.Location = new Point(147, 191);
            coloredNumberTextBox1.Name = "coloredNumberTextBox1";
            coloredNumberTextBox1.NegativeColor = Color.LightCoral;
            coloredNumberTextBox1.PositiveColor = Color.LightGreen;
            coloredNumberTextBox1.Size = new Size(158, 35);
            coloredNumberTextBox1.TabIndex = 0;
            coloredNumberTextBox1.ZeroColor = Color.LightYellow;
            // 
            // coloredNumberTextBox2
            // 
            coloredNumberTextBox2.BackColor = Color.White;
            coloredNumberTextBox2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            coloredNumberTextBox2.Location = new Point(311, 191);
            coloredNumberTextBox2.Name = "coloredNumberTextBox2";
            coloredNumberTextBox2.NegativeColor = Color.LightCoral;
            coloredNumberTextBox2.PositiveColor = Color.LightGreen;
            coloredNumberTextBox2.Size = new Size(158, 35);
            coloredNumberTextBox2.TabIndex = 1;
            coloredNumberTextBox2.ZeroColor = Color.LightYellow;
            // 
            // coloredNumberTextBox3
            // 
            coloredNumberTextBox3.BackColor = Color.White;
            coloredNumberTextBox3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            coloredNumberTextBox3.Location = new Point(475, 191);
            coloredNumberTextBox3.Name = "coloredNumberTextBox3";
            coloredNumberTextBox3.NegativeColor = Color.LightCoral;
            coloredNumberTextBox3.PositiveColor = Color.LightGreen;
            coloredNumberTextBox3.Size = new Size(158, 35);
            coloredNumberTextBox3.TabIndex = 2;
            coloredNumberTextBox3.ZeroColor = Color.LightYellow;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coloredNumberTextBox3);
            Controls.Add(coloredNumberTextBox2);
            Controls.Add(coloredNumberTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsControlLibrary1.ColoredNumberTextBox coloredNumberTextBox1;
        private WinFormsControlLibrary1.ColoredNumberTextBox coloredNumberTextBox2;
        private WinFormsControlLibrary1.ColoredNumberTextBox coloredNumberTextBox3;
    }
}
