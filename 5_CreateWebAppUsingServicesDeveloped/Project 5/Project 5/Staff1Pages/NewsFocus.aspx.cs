using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_5.Staff1Pages
{
    public partial class NewsFocus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut();
            Session["type"] = "";
        }

        protected void GetNewsButton_Click(object sender, EventArgs e)
        {

            RequiredServicesClient.Service1Client newFocusClient = new RequiredServicesClient.Service1Client();
            String words = SerchWordsTextBox.Text;
            String msg = "";
            

            
            try
            {
                String[] links = newFocusClient.NewsFocus(words);
                foreach (String link in links)
                {
                    msg = msg + link + "\n";
                }
            }
            catch (Exception ex)
            {

            }
            if (msg == "")
            {
                NewsFocusOutputTextBox.Enabled = true;
                NewsFocusOutputTextBox.Text = "Sorry Unble to find news related to your topic";
                NewsFocusOutputTextBox.Enabled = false;
            }
            else
            {
                NewsFocusOutputTextBox.Enabled = true;
                NewsFocusOutputTextBox.Text = msg;
                NewsFocusOutputTextBox.Enabled = false;
            }
        }

    }
}