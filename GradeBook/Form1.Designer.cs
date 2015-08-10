namespace GradeBook
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
            this.tabCollection = new System.Windows.Forms.TabControl();
            this.tabAddCourses = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditHours = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CourseName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxStudentLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.textBoxStudentFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxGradeForCourse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabCollection.SuspendLayout();
            this.tabAddCourses.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCollection
            // 
            this.tabCollection.AccessibleName = "";
            this.tabCollection.Controls.Add(this.tabAddCourses);
            this.tabCollection.Controls.Add(this.tabPage2);
            this.tabCollection.Controls.Add(this.tabPage1);
            this.tabCollection.Controls.Add(this.tabPage3);
            this.tabCollection.Controls.Add(this.tabPage4);
            this.tabCollection.Location = new System.Drawing.Point(0, 0);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(465, 434);
            this.tabCollection.TabIndex = 0;
            // 
            // tabAddCourses
            // 
            this.tabAddCourses.Controls.Add(this.label2);
            this.tabAddCourses.Controls.Add(this.comboBox1);
            this.tabAddCourses.Controls.Add(this.btnAddCourse);
            this.tabAddCourses.Controls.Add(this.label1);
            this.tabAddCourses.Controls.Add(this.CreditHours);
            this.tabAddCourses.Controls.Add(this.textBox2);
            this.tabAddCourses.Controls.Add(this.CourseName);
            this.tabAddCourses.Controls.Add(this.textBox1);
            this.tabAddCourses.Location = new System.Drawing.Point(4, 22);
            this.tabAddCourses.Name = "tabAddCourses";
            this.tabAddCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCourses.Size = new System.Drawing.Size(457, 408);
            this.tabAddCourses.TabIndex = 0;
            this.tabAddCourses.Text = "Add Courses";
            this.tabAddCourses.UseVisualStyleBackColor = true;
            this.tabAddCourses.Click += new System.EventHandler(this.tabAddCourses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Courses Available";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(18, 162);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fill out the form below to add a course:";
            // 
            // CreditHours
            // 
            this.CreditHours.AutoSize = true;
            this.CreditHours.Location = new System.Drawing.Point(22, 104);
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.Size = new System.Drawing.Size(65, 13);
            this.CreditHours.TabIndex = 3;
            this.CreditHours.Text = "Credit Hours";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 2;
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(22, 55);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(71, 13);
            this.CourseName.TabIndex = 1;
            this.CourseName.Text = "Course Name";
            this.CourseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxStudentLastName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnAddStudent);
            this.tabPage2.Controls.Add(this.textBoxStudentFirstName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(457, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxStudentLastName
            // 
            this.textBoxStudentLastName.Location = new System.Drawing.Point(33, 103);
            this.textBoxStudentLastName.Name = "textBoxStudentLastName";
            this.textBoxStudentLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentLastName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "First Name";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(33, 148);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // textBoxStudentFirstName
            // 
            this.textBoxStudentFirstName.Location = new System.Drawing.Point(33, 64);
            this.textBoxStudentFirstName.Name = "textBoxStudentFirstName";
            this.textBoxStudentFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentFirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxGradeForCourse);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 408);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Student Grades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxGradeForCourse
            // 
            this.textBoxGradeForCourse.Location = new System.Drawing.Point(14, 142);
            this.textBoxGradeForCourse.Name = "textBoxGradeForCourse";
            this.textBoxGradeForCourse.Size = new System.Drawing.Size(41, 20);
            this.textBoxGradeForCourse.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Grade";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(14, 87);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select Student";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.comboBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(457, 408);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Report Card";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Generate Report Card";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Select Student";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(25, 44);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(457, 408);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Upload List";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "This is a browser dialog***";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Upload Student List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Select a file of students to add:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Select a file of courses to add:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(34, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 20);
            this.textBox4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Upload Course List";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 446);
            this.Controls.Add(this.tabCollection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCollection.ResumeLayout(false);
            this.tabAddCourses.ResumeLayout(false);
            this.tabAddCourses.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCollection;
        private System.Windows.Forms.TabPage tabAddCourses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CreditHours;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox textBoxStudentFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxStudentLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGradeForCourse;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
    }
}

