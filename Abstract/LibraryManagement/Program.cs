using System;
namespace LibraryManagement;

class Program
{
    public static void Main(string[] args)
    {
        EEEdepartment department1 = new EEEdepartment();
        department1.SetBookInfo("Michael","Electricals and Electronics","Royal Publishers",2020);
        department1.DisplayInfo();

        CSEDepartment department2 = new CSEDepartment();
        department2.SetBookInfo("Dennis","intro to C","MM publications",1990);
        department2.DisplayInfo();
    }
}