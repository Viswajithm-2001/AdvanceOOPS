using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    //class for Personal details which will be inherited by userdetails
    public class PersonalDetails
    {
        //Properties
        public string UserName { get; set; }
        public string PhoneNumber {get;set;}
        //Constructor

        /// <summary>
        /// Constructor gets username and phonenumber
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="phoneNumber"></param> <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="phoneNumber"></param>
        public PersonalDetails(string userName,string phoneNumber)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
        }

        //initialise an empty constructor since we are using the UserDetails with one parameter and assignd the values manually.
        public PersonalDetails()
        {
            
        }
    }
}