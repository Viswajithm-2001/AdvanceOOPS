using System;
namespace StudentMarksheet;

class Program
{
    public static void Main(string[] args)
    {
        //Create marksheet object
        MarkSheet markSheet1 = new MarkSheet(1234,"Student1","Father1","+919876543210",new DateTime(1999,10,10),Gender.Male,123456,new DateTime(2019,04,10));
        markSheet1.ProjectMark = 90;
        markSheet1.Sem1 = new int[]{90,91,92,93,95,markSheet1.ProjectMark};
        markSheet1.Sem2 = new int[]{89,90,87,83,85,markSheet1.ProjectMark};
        markSheet1.Sem3 = new int[]{80,81,92,73,75,markSheet1.ProjectMark};
        markSheet1.Sem4 = new int[]{91,92,92,95,99,markSheet1.ProjectMark};
        markSheet1.ShowUGMarkSheet();
        System.Console.WriteLine("Semester 1 :");
        markSheet1.CalculateUG(markSheet1.Sem1);
        System.Console.WriteLine("Semester 2 :");
        markSheet1.CalculateUG(markSheet1.Sem2);
        System.Console.WriteLine("Semester 3 :");
        markSheet1.CalculateUG(markSheet1.Sem3);
        System.Console.WriteLine("Semester 4 :");
        markSheet1.CalculateUG(markSheet1.Sem4);


        System.Console.WriteLine("___________________________________________________________");
        //create object for marksheet
        MarkSheet markSheet2 = new MarkSheet(5678,"Student2","Father2","+919876543211",new DateTime(1997,11,11),Gender.Female,789100,new DateTime(2016,03,29));
        markSheet2.ProjectMark=91;
        markSheet2.Sem1 = new int[]{90,91,92,93,95,markSheet1.ProjectMark};
        markSheet2.Sem2 = new int[]{89,90,87,83,85,markSheet1.ProjectMark};
        markSheet2.Sem3 = new int[]{80,81,92,73,75,markSheet1.ProjectMark};
        markSheet2.Sem4 = new int[]{91,92,92,95,99,markSheet2.ProjectMark};
        markSheet2.ShowUGMarkSheet();
        System.Console.WriteLine("Semester 1 :");
        markSheet2.CalculateUG(markSheet2.Sem1);
        System.Console.WriteLine("Semester 2 :");
        markSheet2.CalculateUG(markSheet2.Sem2);
        System.Console.WriteLine("Semester 3 :");
        markSheet2.CalculateUG(markSheet2.Sem3);
        System.Console.WriteLine("Semester 4 :");
        markSheet2.CalculateUG(markSheet2.Sem4);

    }
}