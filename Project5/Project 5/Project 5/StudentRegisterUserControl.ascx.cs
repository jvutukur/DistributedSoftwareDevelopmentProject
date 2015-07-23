using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_5
{
    public partial class StudentRegisterUserControl : System.Web.UI.UserControl
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
                //capchaValueTB.Text = capchavalue;

            }
        }
        
        protected void getOtherImageButton_Click(object sender, EventArgs e)
        {
            ImageVerifierService.ServiceClient imgserviceclient = new ImageVerifierService.ServiceClient();

            String capchavalue = imgserviceclient.GetVerifierString("5"); //get verifier string of 5 charecters
            Image1.ImageUrl = "http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc//GetImage/" + capchavalue;
            Session["verifyStr"] = capchavalue;
            //capchaValueTB.Text = capchavalue;

        }

        
       
    }
}