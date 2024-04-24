using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApplication
{
    public class EmployeeInfo : FamilyInfo
    {
        //field
        private static int s_employeeID =1000;
        //properties
        public string EmployeeID { get; set; }
        public DateTime DateOfJoining { get; set; }

        public EmployeeInfo(string name, string fatherName,string phoneNumber,string mailID,Gender gender,string motherName,string nativePlace,int noOfSiblings,DateTime doj): base (name, fatherName,phoneNumber,mailID,gender,motherName,nativePlace,noOfSiblings)
        {
            EmployeeID = "EID"+(++s_employeeID);
            DateOfJoining = doj;
        }
        public override void Update()//'EmployeeInfo.Update()': cannot override inherited member 'FamilyInfo.Update()' because it is sealed
        {

        }
        public override void DisplayInfo()//'EmployeeInfo.DisplayInfo()': cannot override inherited member 'FamilyInfo.DisplayInfo()' because it is not marked virtual, abstract, or override
        {

        }

    }
}