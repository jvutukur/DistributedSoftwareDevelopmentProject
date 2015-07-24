using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Project_5.Models;

namespace Project_5.Account
{
    public partial class Register : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
        
          
        }
     
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            String textinImage = (String)Session["verifyStr"];
            //String textinImage = capchaValueTB.Text;
            if (textinImage.Equals(ImageverificationTextBox.Text))
            {
                var manager = new UserManager();
                var user = new ApplicationUser() { UserName = UserName.Text };
                IdentityResult result = manager.Create(user, Password.Text);
                if (result.Succeeded)
                {
                    IdentityHelper.SignIn(manager, user, isPersistent: false);
                    //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                    Response.Redirect("~/StudentPages/Payment.aspx");
                }
                else
                {
                    ErrorMessage.Text = result.Errors.FirstOrDefault();
                }
            }
            else
            {
                ErrorMessage.Text = "Entered Charecters does not match with captcha image. Try again";
            }
        }
    }
}