namespace StudentRegistration
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
            this.Lname = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Program = new System.Windows.Forms.ComboBox();
            this.Register = new System.Windows.Forms.Button();
            this.PicStu = new System.Windows.Forms.PictureBox();
            this.Browse = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicStu)).BeginInit();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(21, 75);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(317, 20);
            this.Lname.TabIndex = 4;
            // 
            // Mname
            // 
            this.Mname.Location = new System.Drawing.Point(21, 179);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(317, 20);
            this.Mname.TabIndex = 5;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(21, 128);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(317, 20);
            this.Fname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Middlename";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender:";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(131, 207);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(75, 24);
            this.Male.TabIndex = 12;
            this.Male.TabStop = true;
            this.Male.Text = "MALE";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(223, 207);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(98, 24);
            this.Female.TabIndex = 13;
            this.Female.TabStop = true;
            this.Female.Text = "FEMALE";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of Birth";
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(130, 243);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(75, 21);
            this.Day.TabIndex = 15;
            this.Day.Text = "Day";
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(211, 243);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(75, 21);
            this.Month.TabIndex = 16;
            this.Month.Text = "Month";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(292, 243);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(75, 21);
            this.Year.TabIndex = 17;
            this.Year.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Program to apply";
            // 
            // Program
            // 
            this.Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program.FormattingEnabled = true;
            this.Program.Location = new System.Drawing.Point(21, 318);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(348, 24);
            this.Program.TabIndex = 19;
            this.Program.Text = "Select Program";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Red;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(19, 348);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(167, 43);
            this.Register.TabIndex = 20;
            this.Register.Text = "Register Student";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // PicStu
            // 
            this.PicStu.Location = new System.Drawing.Point(441, 61);
            this.PicStu.Name = "PicStu";
            this.PicStu.Size = new System.Drawing.Size(138, 138);
            this.PicStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicStu.TabIndex = 21;
            this.PicStu.TabStop = false;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(475, 209);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 22;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 398);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.PicStu);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.Lname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Program;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.PictureBox PicStu;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

