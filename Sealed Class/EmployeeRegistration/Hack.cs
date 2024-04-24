using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public class Hack : EmployeeInfo// we cant inherit a sealed class
    {
        public string StoreUserID{get;set;}
        public string StorePassword{get;set;}
        
        public void ShowKeyInfo()
        {
            System.Console.WriteLine(KeyInfo);// since we can't access anything inside sealed class it shows error
        }
        public void GetUserInfo(EmployeeInfo employee)
        {
            StoreUserID = employee.UserID;
            StorePassword = employee.Password;
        }
        public void ShowUserInfo()
        {
            System.Console.WriteLine($"Stored User ID : {StoreUserID}");
            System.Console.WriteLine($"Stored User Password : {StorePassword}");
        }
        
    }
}