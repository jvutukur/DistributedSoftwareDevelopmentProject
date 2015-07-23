using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraduateProject_WebApplication
{
    public partial class index : System.Web.UI.Page
    {
        protected void GetWindButton_Click(object sender, EventArgs e)
        {
              GraduateProjectServices.Service1Client serviceClient=new GraduateProjectServices.Service1Client();
            String zipcode = wind_zipcodeTextBox1.Text;
            String countrycode = countrycodeTextbox.Text;
            String[] wind = serviceClient.WindIntensity(zipcode,countrycode);

            if (wind[0] == "Invalid input. Please try again")
            {
                windOutput.Text = "Invalid input. Please try againn";
            }
            else
            {
                Table2.Visible = true;
                windOutput.Text = "";

                location.Text = wind[0];
                latitude.Text = wind[1];
                longitude.Text=wind[2];
                windspeed.Text = wind[3];
                winddirection.Text=wind[4];
                

            }
        }
    }
}