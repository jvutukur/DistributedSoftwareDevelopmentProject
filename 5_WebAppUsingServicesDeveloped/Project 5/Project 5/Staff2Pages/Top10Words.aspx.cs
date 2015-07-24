using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_5.Staff2Pages
{
    public partial class Top10Words : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut();
            Session["type"] = "";
        }

        protected void FindTop10WordsButton_Click(object sender, EventArgs e)
        {
            RequiredServicesClient.Service1Client top10WordsServiceClient = new RequiredServicesClient.Service1Client();
            String url = Url_TextBox.Text;
            String[] top10Words = top10WordsServiceClient.Top10Words(url);
            String msg = "";
            try
            {
                foreach (String word in top10Words)
                {
                    msg = msg + word + "\n";
                }
            }
            catch (Exception ex)
            {

            }
            if (msg == "")
            {
                Top10WordsOutputTextBox.Enabled = true;
                Top10WordsOutputTextBox.Text = "Incorrect URL Please try again";
                Top10WordsOutputTextBox.Enabled = false;
            }
            else
            {
                Top10WordsOutputTextBox.Enabled = true;
                Top10WordsOutputTextBox.Text = msg;
                Top10WordsOutputTextBox.Enabled = false;
            }

        }
    }
}