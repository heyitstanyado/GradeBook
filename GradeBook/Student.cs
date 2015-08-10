using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Student
    {
        public string CollegeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
     
        //Keep only for Form1 application
        public string FullName { get; set; }
        public ReportCard ReportCard = new ReportCard(); 
    }
}
