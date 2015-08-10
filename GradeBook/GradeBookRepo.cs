using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO; 
namespace GradeBook
{
    public class GradeBookRepo
    {

        public DataTable StudentRecord;
        public DataTable CourseRecord;


        public GradeBookRepo()
        {
            StudentRecord = new DataTable();
            StudentRecord.Columns.Add("Student", typeof(Student));
            StudentRecord.Columns.Add("ReportCard", typeof(ReportCard));
    
            CourseRecord = new DataTable();
            CourseRecord.Columns.Add("Course", typeof(Course));

            insertSampleData();
            insertStudentData();
        }

        private void insertSampleData()
        {
            addCourse("HIS 100", "Intro to History", 3);
            addCourse("CSC 204", "Java I", 4);
            addCourse("CSC 205", "Java II", 4);
            addCourse("SSE 550", "Object Oriented Programming", 3);

            addStudent("Tanya","Do");
            addStudent("Toby", "Bear");

            //addGrade("4444", "HIS 100", 4.0 );
        }

        private void insertStudentData()
        {
            Student stu = new Student();
            stu.FirstName = "Jim";
            stu.LastName = "Bob";
            stu.CollegeID = "4444";

            ReportCard reportCard = new ReportCard();
            GradeItem gr = new GradeItem();

            gr.CourseCode = "HIS 100";
            gr.Grade = 4.0;
            reportCard.AllGrades.Add(gr);

            gr.CourseCode = "CSC 204";
            gr.Grade = 4.0;
            reportCard.AllGrades.Add(gr);


            StudentRecord.Rows.Add(stu, reportCard); 
        }
        

        public void addGrade(string studentID, string courseCode, double grade)
        {
            GradeItem gradeItem = new GradeItem();
            gradeItem.CourseCode = courseCode;
            gradeItem.Grade = grade; 


            Student student = GetStudentByStudentID(studentID); 
            student.ReportCard.AllGrades.Add(gradeItem); 
        }

        public void addStudent(string firstName, string lastName)
        {
            Student stu = new Student();
            stu.FirstName = firstName;
            stu.LastName = lastName;
            stu.CollegeID = generateStudentID();

            ReportCard reportCard = new ReportCard();

            StudentRecord.Rows.Add(stu, reportCard); 
        }

        private string generateStudentID()
        {
            Random rnd = new Random();
            int id = rnd.Next(10000);
            string studentID = id.ToString("0000");

            return studentID;
        }

        public void addCourse(string courseCode, string courseName, double creditHours)
        {
            Course newCourse = new Course();
            newCourse.CourseCode = courseCode;
            newCourse.CourseName = courseName;
            newCourse.CreditHours = creditHours;

            CourseRecord.Rows.Add(newCourse);
            
        }

        public void CalculateOverallGPA(ReportCard report)
        {
            double totalHours = 0;
            double totalCreditGrades = 0;

            foreach (GradeItem item in report.AllGrades)
            {
                double itemCreditHours = GetCreditHours(item.CourseCode);
                totalHours += itemCreditHours;

                totalCreditGrades += (item.Grade * itemCreditHours);
            }

            report.OverallGPA = totalCreditGrades / totalHours; 

        }

        public double GetCreditHours(string courseCode)
        {
            var credithour = from row in CourseRecord.AsEnumerable()
                             where row.Field<Course>("Course").CourseCode == courseCode
                             select row.Field<Course>("Course").CreditHours;

            double hours = credithour.First();

            return hours; 
        }

        public Student GetStudentByStudentID(string studentID)
        {
            var stu = from row in StudentRecord.AsEnumerable()
                      where row.Field<Student>("Student").CollegeID == studentID
                      select row.Field<Student>("Student");

            return stu.First(); 
        }

        public ReportCard GetReportByStudentID(string studentID)
        {
            var report = from row in StudentRecord.AsEnumerable()
                      where row.Field<Student>("Student").CollegeID == studentID
                      select row.Field<ReportCard>("ReportCard");

            return report.First();
        }

        public List<Student> GetAllStudents()
        {
            var stu = from row in StudentRecord.AsEnumerable()
                      select row.Field<Student>("Student");

            List<Student> allStudents = stu.ToList<Student>(); 

            return allStudents;
        }

        public void writeReport(string studentID)
        {
            Student student = GetStudentByStudentID(studentID); 
            
            string filePath = @"C:\Users\Tanya\Desktop\ReportCard_" + studentID + ".txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Report Card");
                writer.WriteLine("Name: " + student.FirstName + " " + student.LastName);
                writer.WriteLine();
                writer.WriteLine("Overall GPA: " + student.ReportCard.OverallGPA.ToString("0.00"));
                writer.WriteLine("--------------------");
                foreach (GradeItem item in student.ReportCard.AllGrades)
                {
                    writer.WriteLine(item.Course.CourseName.ToUpper());
                    writer.WriteLine("Credit Hours: " + GetCreditHours(item.CourseCode));
                    writer.WriteLine("Class Grade: " + item.Grade.ToString("0.0"));
                    writer.WriteLine();

                    
                }
            }
        }

        public List<Course> GetAllCourses()
        {
            var course = from row in CourseRecord.AsEnumerable()
                      select row.Field<Course>("Course");

            List<Course> allCourses = course.ToList<Course>();

            return allCourses;

        }
    }
}
