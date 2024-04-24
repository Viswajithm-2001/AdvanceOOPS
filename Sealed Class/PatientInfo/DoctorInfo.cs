using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfo
{
    public class DoctorInfo : PatientInfo //we cannot inherit sealed class so it shows error
    {
        //field
        private static int s_doctorID = 2000;

        //property
        public string DoctorID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public DoctorInfo(string name,string father)
        {
            DoctorID = "DID"+(++s_doctorID);
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"Doctor ID : {DoctorID}");
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"FatherName : {FatherName}");
            
        }
    }
}