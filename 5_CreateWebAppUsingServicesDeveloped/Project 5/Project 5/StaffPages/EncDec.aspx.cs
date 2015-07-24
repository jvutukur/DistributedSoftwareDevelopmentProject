using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Project_5.StaffPages
{
    public partial class EncDec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut();
            Session["type"] = "";
        }

        protected void encbutton_Click(object sender, EventArgs e)
        {
            EncryptionService.Service1 encobj = new EncryptionService.Service1();
            String encryptedValueasString=encobj.encrypt(encTb.Text);
            encoutputtb.Enabled = true;
            encoutputtb.Text = encryptedValueasString;
            encoutputtb.Enabled = false;
        }

        protected void decbutton_Click(object sender, EventArgs e)
        {
            DecryptionService.Service1 decobj = new DecryptionService.Service1();
            String decValueAsString = decobj.decryption(encoutputtb.Text);
            decValueAsString = Regex.Replace(decValueAsString, "\0", "");
            decouputtb.Enabled = true;
            decouputtb.Text = decValueAsString;
            decouputtb.Enabled = false;


        }
    }
}