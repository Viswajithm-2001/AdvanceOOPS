using System;
namespace OnlineMedicalStore;
class Program
{
    public static void Main(string[] args)
    {
        FileHandling.Create();

        FileHandling.ReadFromCsv();
        //Operations.Default();
        Operations.MainMenu();
        FileHandling.WriteToCsv();
        
    }
}