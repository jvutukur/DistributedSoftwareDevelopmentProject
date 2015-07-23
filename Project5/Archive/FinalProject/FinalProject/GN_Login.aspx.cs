using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;
namespace FinalProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void loginButton_Click(object sender, EventArgs e)
        {
            String userName=unameTextBox.Text;
            String password=pwdTextBox.Text;
            String userType=userTypeSelect.Value;
            String pathofXmlFile = "";
            if(userType.Equals("Student"))
            {
                Boolean isAuthenticated = false;
                pathofXmlFile = HttpContext.Current.Server.MapPath(".") + "\\" + "App_Data" + "\\" + "StudentAccounts.xml";
                XmlSerializer studentAccountSerializer=new XmlSerializer(typeof(List<StudentAccount>));
                StreamReader reader=new StreamReader(pathofXmlFile);
                List<StudentAccount> studentAccountList = (List<StudentAccount>)studentAccountSerializer.Deserialize(reader);
                reader.Close();
                String firstName = "";
                foreach(StudentAccount account in studentAccountList)
                {
                    if(account.userName.Equals(userName))
                    {
                        if(account.password.Equals(password))
                        {
                            firstName = account.name;
                            isAuthenticated = true;
                            break;
                        }
                    }
                }
                if(isAuthenticated==true)
                {
                    //redirect to Student Home page
                    
                }

            }
            else if(userType.Equals("Staff"))
            {

            }
            
            
            StreamReader reader=new StreamReader(studentAccountsFilePath);
        }
    }
}