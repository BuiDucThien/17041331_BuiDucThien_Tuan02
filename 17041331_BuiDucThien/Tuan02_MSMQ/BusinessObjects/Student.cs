using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Serializable]
    public class Student
    {
        static void Main(string[] args)
        {

        }
        public long StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public Student() : this(0, "no-name", new DateTime())
        {

        }
        public Student(long id, string fname, DateTime dob)
        {
            StudentID = id; FullName = fname; DOB = dob;
        }
        public override string ToString()
        {
            return FullName + "\t" + DOB;
        }
    }
}
