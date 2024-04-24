using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksheet
{
    public class MarkSheet:TheoryExamMarks,ICalculate
    {
        public int MarksheetNumber { get; set; }
        public DateTime DateOfIssue {get;set;}
        public int Total{get;set;}
        public double Percentage{get;set;}
        public int ProjectMark{get;set;}

        public MarkSheet(long registrationNumber,string name,string fathername,string phoneNumber,DateTime dob,Gender gender,int marksheetNumber,DateTime dateOfIssue):base (registrationNumber,name,fathername,phoneNumber,dob,gender)
        {
            DateOfIssue = dateOfIssue;
            MarksheetNumber = marksheetNumber;
        }

        public void CalculateUG(int[] sem)
        {
            Total = 0;
            Percentage = 0;
            for(int i=0;i<sem.Length;i++)
            {
                Total+=sem[i];
            }
            Percentage = (double)Total/6;
            System.Console.WriteLine($"Total : {Total}");
            System.Console.WriteLine($"Percentage : {Math.Round(Percentage,2)}");

        }
        public void ShowUGMarkSheet()
        {
            System.Console.WriteLine($"Register Number : {RegistrationNumber}");
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Father Name : {Fathername}");
            System.Console.WriteLine($"Phone Number : {PhoneNumber}");
            System.Console.WriteLine($"Date of Birth : {Dob.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Gender : {Gender}");
            System.Console.WriteLine($"Date of Issue : {DateOfIssue.ToString("dd/MM/yyyy")}");
        }

    }
}