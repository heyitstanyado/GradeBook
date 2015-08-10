using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    //[Serializable]
    public class Teacher: IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CollegeID { get; set; }


        //public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
