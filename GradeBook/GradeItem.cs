using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeItem
    {
        public string CourseCode;
        public double Grade;

        // deprecated
        public Course Course = new Course();
        
    }
}
