using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksheet
{
    public class TheoryExamMarks : PersonalInfo
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }
        
        public TheoryExamMarks(long registrationNumber,string name,string fathername,string phoneNumber,DateTime dob,Gender gender):base (registrationNumber,name,fathername,phoneNumber,dob,gender)
        {
            Sem1 = new int[6];
            Sem2 = new int[6];
            Sem3 = new int[6];
            Sem4 = new int[6];
        }

    }
}