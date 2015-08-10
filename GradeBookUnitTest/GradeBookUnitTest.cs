using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;
using System.Data;

namespace GradeBookUnitTest
{
    [TestClass]
    public class GradeBookUnitTest
    {
        [TestMethod]
        public void GradeBookRepo__AddCourse__AddsOneCourseRecord()
        {
            //Arrange
            GradeBookRepo repo = new GradeBookRepo();

            //Act
            repo.addCourse("ART 200", "Visual Arts", 3);

           //Assert
            Assert.IsTrue(repo.CourseRecord.Rows.Count >= 1, "At least one row should exist");
        }

        [TestMethod]
        public void GradeBookRepo__AddStudent__AddsOneStudent()
        {
            //Arrange
            GradeBookRepo repo = new GradeBookRepo();

            //Act
            repo.addStudent("Bob", "Jones");

            //Assert
            Assert.IsTrue(repo.StudentRecord.Rows.Count >= 1, "At least one row should exist");
        }

        [TestMethod]
        public void GradeBookRepo__GetCreditHours__ReturnHours()
        {
            GradeBookRepo repo = new GradeBookRepo();
            double hours = repo.GetCreditHours("HIS 100");
            Assert.IsTrue(hours == 3.0, "Credit hour of 3, is returned");
        }

        [TestMethod]
        public void GradeBookRepo__CalculateOverallGPA__SetGPA()
        {
            ReportCard reportCard = new ReportCard();
            GradeItem gr = new GradeItem();

            gr.CourseCode = "HIS 100";
            gr.Grade = 4.0;
            reportCard.AllGrades.Add(gr);

            gr.CourseCode = "CSC 204";
            gr.Grade = 4.0;
            reportCard.AllGrades.Add(gr);

            GradeBookRepo repo = new GradeBookRepo();
            repo.CalculateOverallGPA(reportCard);


            Assert.IsTrue(reportCard.OverallGPA == 4.0, "Perfect grade");

        }

        [TestMethod]
        public void GradeBookRepo__addGrade__works()
        {
            GradeBookRepo repo = new GradeBookRepo();
            
            repo.addGrade("4444", "HIS 100", 4.0);

            Student stu = repo.GetStudentByStudentID("4444");
            Assert.IsTrue(stu.ReportCard.AllGrades.Count > 0, "At least one record");
        }

       
    }
}
