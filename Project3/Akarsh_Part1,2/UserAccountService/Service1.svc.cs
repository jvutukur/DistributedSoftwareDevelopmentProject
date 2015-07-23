using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;


namespace UserAccountService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        XmlSerializer accountSerializer = new XmlSerializer(typeof(List<UserAccountDetails>));
        // File path of user accounts xml
        string accountFilePath = HttpContext.Current.Server.MapPath(".") + "\\" + "App_Data" + "\\" + "UserAccounts.xml";
        
        public bool CreateAccount(String name, String emailId, String username, String password, String address, String phoneNo)
        {
            UserAccountDetails userAccount = new UserAccountDetails(name, emailId, username, password, address, phoneNo);

            List<UserAccountDetails> userAccounts = new List<UserAccountDetails>();

            // Checking if file already exists
            if (File.Exists(accountFilePath))
            {
                Stream stream = new FileStream(accountFilePath, FileMode.Open);
                long length = stream.Length;

                if (length == 0)
                {
                    stream.Close();
                    userAccounts.Add(userAccount);
                    XmlWriter writer = new XmlTextWriter(accountFilePath, encoding: null);
                    accountSerializer.Serialize(writer, userAccounts);
                    writer.Close();
                }
                else
                {
                    XmlReader reader = new XmlTextReader(stream);
                    userAccounts = (List<UserAccountDetails>)accountSerializer.Deserialize(reader);
                    reader.Close();
                    stream.Close();
                    userAccounts.Add(userAccount);
                    XmlWriter writer = new XmlTextWriter(accountFilePath, encoding: null);
                    accountSerializer.Serialize(writer, userAccounts);
                    writer.Close();
                }

            }
            else
            {
                userAccounts.Add(userAccount);
                XmlWriter writer = new XmlTextWriter(accountFilePath, encoding: null);
                accountSerializer.Serialize(writer, userAccounts);
                writer.Close();
            }
            return true;
        }
        
        public bool Login(string username, string password)
        {
            StreamReader reader = new StreamReader(accountFilePath);
            List<UserAccountDetails> userAccounts = (List<UserAccountDetails>)accountSerializer.Deserialize(reader);
            reader.Close();
            bool isAuthenticated = false;

            foreach (UserAccountDetails userAccount in userAccounts.Where(userAccount => userAccount.Username == username && userAccount.Password == password))
            {
                isAuthenticated = true;
            }
            return isAuthenticated;
        }
        
        public bool EditAccount(String name, String emailId, String username, String password, String address, String phoneNo)
        {
            bool isUpdated = false;

            StreamReader reader = new StreamReader(accountFilePath);
            List<UserAccountDetails> userAccounts = (List<UserAccountDetails>)accountSerializer.Deserialize(reader);
            reader.Close();

            XmlDocument xml = new XmlDocument();
            xml.Load(accountFilePath);
            
            
            
            foreach (UserAccountDetails userAccount in userAccounts)
            {
                string email = userAccount.EmailId;
                if (email.Equals(emailId))
                {
                    if (name != null)
                    {
                        //xml.SelectSingleNode("//UserAccountDetails/Name").InnerText = name;
                        //name1 = name;
                        changeValue(name, "Name", xml, emailId);
                    }

                    if (username != null)
                    {
                        changeValue(username, "Username", xml, emailId);
                    }
                    

                    if (password != null)
                    {
                        changeValue(password, "Password", xml, emailId);
                    }

                    if (address != null)
                    {
                        changeValue(address, "Address", xml, emailId);
                    }

                    if (phoneNo != null)
                    {
                        changeValue(phoneNo, "PhoneNumber", xml, emailId);
                    }
                    isUpdated = true;
                }
            }
            return isUpdated;
        }

        public void changeValue(string name, string tag, XmlDocument xml,string emailId)
        {
            foreach (XmlElement element in xml.SelectNodes("//UserAccountDetails"))
            {
                foreach (XmlElement element1 in element)
                {
                    if (element.SelectSingleNode("//EmailId").InnerText==emailId)
                    {
                      
                        XmlNodeList childTags = element.GetElementsByTagName(tag);
                        XmlNode oldValue= childTags[0];
                        XmlNode newvalue = xml.CreateElement(tag);
                        newvalue.InnerText = name;
                        element.ReplaceChild(newvalue, oldValue);
                        xml.Save(accountFilePath);
                       
                    }
                }
            }
        }
    }
}

// XmlNode newvalue = xml.CreateElement(tag);
 //                           newvalue.InnerText = name;
 //                           element.ReplaceChild(newvalue, element1);