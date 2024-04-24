using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPartial
{
    public partial class StudentInfo
    {
        public StudentInfo(string name ,Gender gender,DateTime dob,string mobileNumber,int physicsMark,int chemistryMark,int mathsMark)
        {
            StudentID = "SID"+(++s_studentID);
            Name = name;
            Gender = gender;
            Dob =dob;
            MobileNumber = mobileNumber;
            PhysicsMark = physicsMark;
            ChemistryMark = chemistryMark;
            MathsMark=mathsMark;

        }
        
    }
}