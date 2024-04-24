using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfo
{
    public sealed class PatientInfo
    {

        //field
        private static int s_patientID=1000;
        //properties

        public string PatientID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo{get;set;}
        public string NativePlace {get;set;}
        public string AdmittedFor{get;set;}

        public PatientInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            PatientID = "PID"+(++s_patientID);
            Name = name;
            FatherName = fatherName;
            BedNo = bedNo ;
            NativePlace = nativePlace;
            AdmittedFor = admittedFor;
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"Patient ID : {PatientID}");
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"FatherName : {FatherName}");
            System.Console.WriteLine($"Bed Number : {BedNo}");
            System.Console.WriteLine($"Native Place: {NativePlace}");
            System.Console.WriteLine($"Admitted for : {AdmittedFor}");
        }
        
    }
}