using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class StudentAccount
    {
        public String name;
        public String emailID;
        public String userName;
        public String password;        

        //Constructor for account to students
        public StudentAccount(String name, String emailID, String userName, String password)
        {
            this.name = name;
            this.emailID = emailID;
            this.userName = userName;
            this.password = password;            
        }
        public StudentAccount()
        {

        }
    }
}