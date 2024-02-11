namespace RomanNumeralsHelper
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
            this.Label0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text =  "Arabic:";
            this.Label0.Location = new System.Drawing.Point(24,80);
            this.Label0.Size = new System.Drawing.Size(41,15);
            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.Text =  "Roman:";
            this.Label1.Location = new System.Drawing.Point(24,156);
            this.Label1.Size = new System.Drawing.Size(41,15);
            this.Label1.TabIndex = 1;
            //
            // PictureBox2
            //
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.Text =  "Ptolemy";
            this.PictureBox2.Image = Image.FromFile(@"./Ptolemy.png");
            this.PictureBox2.SizeMode =  PictureBoxSizeMode.Zoom;
            this.PictureBox2.Location = new System.Drawing.Point(220,44);
            this.PictureBox2.Size = new System.Drawing.Size(224,300);
            //
            // Label3
            //
            this.Label3.AutoSize =  true;
            this.Label3.Text =  "Конвертатор арабской записи чисел в римскую и из римской в арабскую";
            this.Label3.Location = new System.Drawing.Point(24,16);
            this.Label3.Size = new System.Drawing.Size(415,15);
            this.Label3.TabIndex = 3;
            //
            // TextBox4
            //
            this.TextBox4.Text =  "";
            this.TextBox4.Location = new System.Drawing.Point(96,76);
            this.TextBox4.TabIndex = 4;
            //
            // TextBox5
            //
            this.TextBox5.Text =  "";
            this.TextBox5.Location = new System.Drawing.Point(96,152);
            this.TextBox5.TabIndex = 5;
            //
            // Button6
            //
            this.Button6.Text =  "Конвертировать";
            this.Button6.Location = new System.Drawing.Point(20,260);
            this.Button6.Size = new System.Drawing.Size(176,84);
            this.Button6.TabIndex = 6;
            //
            // Label8
            //
            this.Label8.AutoSize =  true;
            this.Label8.Text =  "Результат";
            this.Label8.Location = new System.Drawing.Point(80,116);
            this.Label8.Size = new System.Drawing.Size(41,15);
            this.Label8.TabIndex = 8;
            //
            // Label9
            //
            this.Label9.AutoSize =  true;
            this.Label9.Text =  "Результат";
            this.Label9.Location = new System.Drawing.Point(80,192);
            this.Label9.Size = new System.Drawing.Size(41,15);
            this.Label9.TabIndex = 9;
         //
         // form
         //
            this.Size = new System.Drawing.Size(480,400);
            this.Text =  "Form1";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox TextBox5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
    }
}