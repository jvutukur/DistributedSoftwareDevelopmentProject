using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Serialization;


namespace FinalProject
{
    public partial class Register : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void createAccount_Click(object sender, EventArgs e)
        {
            String firstName=firstNameTextBox.Text;
            String emailID=emailTextBox.Text;
            String userName=usernameTextBox.Text;
            String password=passwordTextBox.Text;

            registerOutput.Text = "";
            
            StudentAccount newaccount = new StudentAccount(firstName, emailID, userName, password);
            String pathofXmlFile = HttpContext.Current.Server.MapPath(".") + "\\" + "App_Data" + "\\" + "StudentAccounts.xml";
            XmlSerializer serializerobj = new XmlSerializer(typeof(List<StudentAccount>));                                    
            List<StudentAccount> accountsList = new List<StudentAccount>();
            if(File.Exists(pathofXmlFile)) //if xml file is available at required location. Add record to it
            {
                Stream stream = new FileStream(pathofXmlFile, FileMode.Open);
                long length = stream.Length;

                if(length!=0) //if file already has some records
                {
                    XmlReader reader = new XmlTextReader(stream);                    
                    accountsList = (List<StudentAccount>)serializerobj.Deserialize(reader);                    
                    accountsList.Add(newaccount);
                    reader.Close();
                    stream.Close();
                    XmlWriter writer = new XmlTextWriter(pathofXmlFile, encoding: null);
                    serializerobj.Serialize(writer, accountsList);
                    writer.Close();
                }
                else //if file is present and is empty
                {
                    accountsList.Add(newaccount);
                    stream.Close();
                    XmlWriter writer = new XmlTextWriter(pathofXmlFile, encoding: null);
                    serializerobj.Serialize(writer, accountsList);
                    writer.Close();
                }
            }
            else //xml file is not available at given location. So create a file and add record to it
            {
                accountsList.Add(newaccount);             
                XmlWriter writer = new XmlTextWriter(pathofXmlFile, encoding: null);
                serializerobj.Serialize(writer, accountsList);
                writer.Close();
            }

            firstNameTextBox.Text = "";
            emailTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            registerOutput.Text = "Registerd Successfully. Now you can login as student";

        }
    }
}