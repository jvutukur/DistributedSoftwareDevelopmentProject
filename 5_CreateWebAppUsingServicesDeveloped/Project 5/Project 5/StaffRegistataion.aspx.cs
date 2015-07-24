using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using DecryptionService;
using EncryptionService;

namespace Project_5
{
    public partial class StaffRegistataion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                string capchavalue = "";
                ImageVerifierService.ServiceClient imgclient = new ImageVerifierService.ServiceClient();
                capchavalue = imgclient.GetVerifierString("5");
                Image1.ImageUrl = "http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc//GetImage/" + capchavalue;
                Session["verifyStr"] = capchavalue;
                capchaValueTB.Text = capchavalue;
            }
            


        }

        protected void getOtherImageButton_Click(object sender, EventArgs e)
        {
            ImageVerifierService.ServiceClient imgserviceclient = new ImageVerifierService.ServiceClient();

            String capchavalue = imgserviceclient.GetVerifierString("5"); //get verifier string of 5 charecters
            Image1.ImageUrl = "http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc//GetImage/" + capchavalue;
            Session["verifyStr"] = capchavalue;
            capchaValueTB.Text = capchavalue;

        }

        protected void registerbutton_Click(object sender, EventArgs e)
        {
            DecryptionService.Service1 dec = new DecryptionService.Service1(); //Creating object for the class in DLL
            EncryptionService.Service1 enc = new EncryptionService.Service1();  //Creating object for the class in DLL

            String pwd1AsString = pwd1tb.Text;
            String pwd2AsString = pwd2tb.Text;
            
            //String textinImage=(String)Session["verifyStr"];
            String textinImage = capchaValueTB.Text;
            if(pwd1AsString.Equals(pwd2AsString) && !pwd1tb.Text.Equals(""))
            {
                if (textinImage.Equals(ImageverificationTextBox.Text))
                {

                
                String pathofXmlFile = HttpContext.Current.Server.MapPath(@"~\") + "\\" + "App_Data" + "\\" + "staffCredentials.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathofXmlFile);



                XmlNode staff = xmlDoc.CreateElement("staff");
                XmlNode userName = xmlDoc.CreateElement("username");
                userName.InnerText = usernametextbox.Text;
                staff.AppendChild(userName);

                String encpwd = enc.encrypt(pwd1AsString);
                
                XmlNode pwd = xmlDoc.CreateElement("password");
                pwd.InnerText = encpwd;
                staff.AppendChild(pwd);

                XmlNode email = xmlDoc.CreateElement("email");
                email.InnerText = emailTB.Text;
                staff.AppendChild(email);
                    
                xmlDoc.DocumentElement.AppendChild(staff);                
                xmlDoc.Save(pathofXmlFile);

                FailureText.Text = "Registration successful";
                ErrorMessage.Visible = true;
                usernametextbox.Text = "";
                pwd1tb.Text = "";
                pwd2tb.Text = "";
                emailTB.Text = "";
                ImageverificationTextBox.Text = "";                
                }
                else{
                    FailureText.Text = "Entered Charecters does not match with captcha image. Try again";
                    ErrorMessage.Visible = true;
                }

            }
            else
            {
                FailureText.Text = "Password does not match please try again ";
                ErrorMessage.Visible = true;
            }

        }
    }
}