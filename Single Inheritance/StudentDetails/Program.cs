using System;
namespace StudentDetails;

class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new StudentInfo("Viswajith","Mathialagan","+918870306924","viswajith@gmail.com",new DateTime(2001,11,02),Gender.Male,123018116,12,"Computer",2019);
        StudentInfo student2 = new StudentInfo("GirlName","HerFather","+918870306924","she@gmail.com",new DateTime(2001,11,02),Gender.Female,123018116,12,"Computer",2019);

        student1.ShowStudentInfo();
        student2.ShowStudentInfo();
    }
}