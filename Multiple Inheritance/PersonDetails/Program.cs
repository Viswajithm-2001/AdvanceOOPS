using System;
namespace PersonDetails;
class Program
{
    public static void Main(string[] args)
    {
        RegisterPerson person1 = new RegisterPerson("Person1",Gender.Male,new DateTime(2000,11,11),"+919876543210",MaritalStatus.Single,"Father1","Mother1","Address1",2,DateTime.Now);
        person1.ShowInfo();
        RegisterPerson person2 = new RegisterPerson("Person2",Gender.Female,new DateTime(2001,11,11),"+919876543211",MaritalStatus.Married,"Father2","Mother2","Address2",1,DateTime.Now);
        person2.ShowInfo();
    }
}