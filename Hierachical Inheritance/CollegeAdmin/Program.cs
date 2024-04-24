using System;
using System.Collections.Generic;

namespace CollegeAdmin;

class Program
{
    public static void Main(string[] args)
    {
        List<TeacherInfo> teachersList = new List<TeacherInfo>();
        List<StudentInfo> studentsList = new List<StudentInfo>();
        List<PrincipalInfo> principalList = new List<PrincipalInfo>();


        TeacherInfo teacher1 = new TeacherInfo("Teacher1","Teacher1Father","+919876543210","teacher1@mail.com",new DateTime(1980,11,11),Gender.Male,"Computer Science","DSA","Ph.D",10,new DateTime(2010,10,10));
        TeacherInfo teacher2 = new TeacherInfo("Teacher2","Teacher2Father","+919876543211","teacher2@mail.com",new DateTime(1981,10,20),Gender.Female,"Civil","Construction Management","Ph.D",9.5,new DateTime(2013,11,13));
        TeacherInfo teacher3 = new TeacherInfo("Teacher3","Teacher3Father","+919876543212","teacher3@mail.com",new DateTime(1985,04,10),Gender.Male,"EEE","Electronics Enginering","Ph.D",11,new DateTime(2013,09,15));
        teachersList.Add(teacher1);
        teachersList.Add(teacher2);
        teachersList.Add(teacher3);

        StudentInfo student1 = new StudentInfo("student1","student1Father","+919876543213","student1@mail.com",new DateTime(2000,12,12),Gender.Male,"B.Tech","CSE",5);
        StudentInfo student2 = new StudentInfo("student2","student3Father","+919876543214","student2@mail.com",new DateTime(2002,01,08),Gender.Male,"B.Sc","Maths",5);
        StudentInfo student3 = new StudentInfo("student3","student3Father","+919876543215","student3@mail.com",new DateTime(2001,11,10),Gender.Male,"B.A","Englise",5);
        studentsList.Add(student1);
        studentsList.Add(student2);
        studentsList.Add(student3);
        


        PrincipalInfo principal1 = new PrincipalInfo("Principal1","Principal1Father","+919876543216","principal1@mail.com",new DateTime(1970,08,20),Gender.Female,"Ph.D",35,new DateTime(2005,05,05));
        PrincipalInfo principal2 = new PrincipalInfo("Principal2","Principal2Father","+919876543217","principal2@mail.com",new DateTime(1972,08,20),Gender.Female,"Ph.D",34,new DateTime(2005,12,05));
        PrincipalInfo principal3 = new PrincipalInfo("Principal3","Principal3Father","+919876543218","principal3@mail.com",new DateTime(1969,08,20),Gender.Female,"Ph.D",36,new DateTime(2005,10,06));

        principalList.Add(principal1);
        principalList.Add(principal2);
        principalList.Add(principal3);

        Console.WriteLine("Teachers.....");
        foreach(TeacherInfo teacher in teachersList)
        {
            Console.WriteLine("___________________________________");
            teacher.ShowDetails();
            Console.WriteLine("___________________________________");

        }
        Console.WriteLine("Students....");
        foreach(StudentInfo student in studentsList)
        {
            Console.WriteLine("___________________________________");
            student.ShowDetails();
            Console.WriteLine("___________________________________");
        }
        Console.WriteLine("Principal....");
        foreach(PrincipalInfo principal in principalList)
        {
            Console.WriteLine("___________________________________");
            principal.ShowDetails();
            Console.WriteLine("___________________________________");
        }
    
    }
}