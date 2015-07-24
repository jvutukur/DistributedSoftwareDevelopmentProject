using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.Security;
using System.Text.RegularExpressions;

namespace Project_5
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void loginbutton_Click(object sender, EventArgs e)
        {
            DecryptionService.Service1 dec = new DecryptionService.Service1();

            String username=usernametb.Text;
            String pwd=pwdtb.Text;

            String pathofxmlFile=  HttpContext.Current.Server.MapPath(@"~\") + "\\" + "App_Data" + "\\" + "staffCredentials.xml";
            //Request.PhysicalApplicationPath
            //HttpRuntime.AppDomainAppPath

            XmlDocument xd = new XmlDocument();
            xd.Load(pathofxmlFile);
            
            XmlNode node=xd.DocumentElement;
            XmlNodeList children=node.ChildNodes;
            int flag=0;
            
            
            foreach(XmlNode child in children)
            {
                if(child.FirstChild.InnerText.Equals(username))
                {
                    String encpwd=child.SelectSingleNode("password").InnerText;
                     
                    String decpwd = dec.decryption(encpwd);
                    decpwd = Regex.Replace(decpwd, "\0", "");
                    if (decpwd.Equals(pwd))
                    {
                        flag++;
                        Session["type"] = "staff";
                        break;
                    }
                }
            }
            if(flag==0)
            {
                FailureText.Text="Invalid credentails. Please Try again";
                ErrorMessage.Visible = true;
            }
            if(flag!=0)
            {
                Session["name"] = username;
                FormsAuthentication.RedirectFromLoginPage(username, true);
                Response.Redirect("~/StaffPages/EncDec");
            }
        }
    }
}