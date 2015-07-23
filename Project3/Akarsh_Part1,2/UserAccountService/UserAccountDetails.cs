using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace UserAccountService
{
    [DataContract]
    public class UserAccountDetails
    {
        public String Name { get; set; }
        public String EmailId { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }

        // Parametered constructor
        public UserAccountDetails(String name, String emailId, String username, String password, String address, String phoneNo)
        {
            Name = name;
            EmailId = emailId;
            Username = username;
            Password = password;
            Address = address;
            PhoneNumber = phoneNo;
        }

        // Parameterless constructor for serialization
        public UserAccountDetails()
        { 
        
        }
    }
}