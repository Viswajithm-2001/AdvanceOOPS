using System;
namespace MetroCardManagement;

class Program
{
    public static void Main(string[] args)
    {
        //Creating a folders and file if it ain't exists
        FileHandling.Create();

        //Gets values assigned from csv which stores the values even if the program closed
        FileHandling.ReadFromCsv();

        //this one stores default function since we used ReadFromCsv method it wont used anymore
        //Operations.DefaultDetails();

        //Mainmenu of our Application
        Operations.MainMenu();
        //Once the operations done the values in the lists will erase, so we store it in csv file
        FileHandling.WriteToCsv();
    }
}