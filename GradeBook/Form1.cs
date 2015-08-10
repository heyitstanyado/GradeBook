using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBook
{
    public partial class Form1 : Form
    {
        enum LetterGrade { A = 4, B = 4, C = 4, D = 4, F = 0 }

        public List<Course> AllCourseAvailable;
        public List<Student> AllStudents;

        public Form1()
        {
            InitializeComponent();
            AllCourseAvailable = new List<Course>();
            AllStudents = new List<Student>(); 


            //////////

            Course classes = new Course();
            classes.CourseName = "Math";
            classes.CreditHours = 4;
            Course classes2 = new Course();
            classes2.CourseName = "English";
            classes2.CreditHours = 3;

            AllCourseAvailable.Add(classes);
            AllCourseAvailable.Add(classes2);
            refreshAllCourseBoxes(); 


            Student student1 = new Student();
            student1.FullName = "Jame Novak";
            Student student2 = new Student();
            student2.FullName = "Nate Silver";

            AllStudents.Add(student1);
            AllStudents.Add(student2);
            refreshStudentComboBox();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabAddCourses_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = textBox1.Text;
            double creditHours = 0; ;
            try
            {

                creditHours = double.Parse(textBox2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Credit Hours must be a number.");
            }
            Course newCourse = new Course();
            newCourse.CourseName = courseName;
            newCourse.CreditHours = creditHours;

            AllCourseAvailable.Add(newCourse);

            textBox1.Text = "";
            textBox2.Text = "";

            refreshAllCourseBoxes();

            //comboBox1.Refresh(); 
        }

        private void refreshAllCourseBoxes()
        {
            comboBox1.DataSource = null; 
            comboBox1.DataSource = AllCourseAvailable;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseName";

            comboBox3.DataSource = null;
            comboBox3.DataSource = AllCourseAvailable;
            comboBox3.DisplayMember = "CourseName";
            comboBox3.ValueMember = "CourseName";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Refresh();
            //comboBox1.DisplayMember = "CourseName"; 
        }

        public void CalculateOverallGPA(ReportCard report)
        {
            double totalCreditHours = 0;
            double totalCreditGrades = 0;

            foreach (GradeItem item in report.AllGrades)
            {
                double indivCreditGrade = item.Grade * item.Course.CreditHours;

                totalCreditGrades += indivCreditGrade;
                totalCreditHours += item.Course.CreditHours;
            }

            report.OverallGPA = totalCreditGrades / totalCreditHours;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //listBox1.DataSource = AllCourseAvailable;

        }

        private void refreshStudentComboBox()
        {
            comboBox2.DataSource = null; 
            comboBox2.DataSource = AllStudents;
            comboBox2.DisplayMember = "FullName";
            comboBox2.ValueMember = "FullName";


            comboBox4.DataSource = null;
            comboBox4.DataSource = AllStudents;
            comboBox4.DisplayMember = "FullName";
            comboBox4.ValueMember = "FullName";
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            addOneStudent(textBoxStudentFirstName.Text, textBoxStudentLastName.Text);

            textBoxStudentFirstName.Text = "";
            textBoxStudentLastName.Text = "";

            refreshStudentComboBox();
        }

        private void addOneStudent(string firstName, string lastName)
        {
            ReportCard report = new ReportCard();

            Student newStudent = new Student();
            newStudent.FirstName = firstName;
            newStudent.LastName = lastName;
            newStudent.FullName = newStudent.FirstName + " " + newStudent.LastName;
            newStudent.ReportCard = report;

            AllStudents.Add(newStudent);
        }

        private void addStudentsFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                var name = line.Split(' ');

                string firstName = name[0];
                string lastName = name[1];

                addOneStudent(firstName, lastName);
            }
            reader.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GradeItem item = new GradeItem();
            item.Course = (Course)comboBox3.SelectedItem;
            try
            {
                item.Grade = double.Parse(textBoxGradeForCourse.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grade value must be a number.");
            }
            string name = comboBox2.SelectedValue.ToString(); 
           
            foreach (Student student in AllStudents)
            {
                if (student.FullName == name)
                {
                    //student.ReportCard.AllGrades = new List<GradeItem>(); 
                    student.ReportCard.AllGrades.Add(item);
                }
            }

            textBoxGradeForCourse.Text = "";
        }

        private void writeReport(Student student)
        {
            string filePath = @"C:\Users\Tanya\Desktop\ReportCard.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Report Card");
                writer.WriteLine("Name: " + student.FullName);
                writer.WriteLine();
                writer.WriteLine("Overall GPA: " + student.ReportCard.OverallGPA.ToString("0.00"));
                writer.WriteLine("--------------------");
                foreach (GradeItem item in student.ReportCard.AllGrades)
                {
                    writer.WriteLine(item.Course.CourseName.ToUpper());
                    writer.WriteLine("Credit Hours: " + item.Course.CreditHours.ToString());
                    writer.WriteLine("Class Grade: " + item.Grade.ToString("0.0"));
                    writer.WriteLine();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = comboBox4.SelectedValue.ToString();

            foreach (Student student in AllStudents)
            {
                if (student.FullName == name)
                {
                    CalculateOverallGPA(student.ReportCard);
                    writeReport(student);
                }

            }

            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path;

            DialogResult result = openFileDialog1.ShowDialog();
            path = textBox3.Text = openFileDialog1.FileName;

            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    addStudentsFromFile(path);
                }
                catch (IOException)
                {
                }

            }
            refreshStudentComboBox();
        }
    }
}
