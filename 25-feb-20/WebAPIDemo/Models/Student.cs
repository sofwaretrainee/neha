using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        public int Id { get; set; }
        public string studentFirst_name { get; set; }
        public string studentLast_name { get; set; }
        public string student_gender { get; set; }
        public DateTime student_Dob { get; set; }
        public string Passsword { get; set; }
        public Int64 student_mobileno { get; set; }
        public string student_address { get; set; }
    }
}
