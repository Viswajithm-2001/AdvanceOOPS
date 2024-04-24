using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public static class Operations
    {
        static HSCDetails currentStudentClass;
        public static void MainMenu()
        {
            //Two student details are added manually.
        HSCDetails student1 = new HSCDetails("User1","User1Father","+918870306924","user1@gmail",new DateTime(2001,11,02),Gender.Male,90900999999023);
        HSCDetails student2 = new HSCDetails("User2","User2Father","+918870306924","user2@mail.com",new DateTime(2001,11,02),Gender.Female,90900999999024);
        Console.WriteLine("Two students are created successfully..");
        Console.Write("Enter \n1. Student1\n2. Student2\n");
        int student = int.Parse(Console.ReadLine());
        if(student == 1)
        {
            currentStudentClass = student1;
        }
        else 
        {
            currentStudentClass = student2;
        }
        SubMenu();
        }
        static void SubMenu()
        {
            string choice;
            currentStudentClass.GetStudentInfo();
            currentStudentClass.ShowInfo();
            currentStudentClass.GetMarks();
            currentStudentClass.Calculate();
            Console.Write("Do you want to show your Marksheet (yes/no) : ");
            choice = Console.ReadLine().ToLower();
            if(choice=="yes")
            {
                currentStudentClass.ShowMarkSheet();
            }
        }
    }
}