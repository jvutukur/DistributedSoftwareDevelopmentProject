using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryItPages
{
    public partial class EncryptDecryptTryItPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void GetNewsButton_Click(object sender, EventArgs e)
        {

            RequiredServicesClient.Service1Client newFocusClient = new RequiredServicesClient.Service1Client();
            String words = SerchWordsTextBox.Text;
            String[] links = newFocusClient.NewsFocus(words);

            String msg = "";
            try
            {
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