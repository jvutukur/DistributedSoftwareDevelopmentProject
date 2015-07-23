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
        protected void GetWeatherButton_Click(object sender, EventArgs e)
        {
            
            GraduateProjectServices.Service1Client serviceClient=new GraduateProjectServices.Service1Client();
            String zipcode = weather_zipcodeTextBox1.Text;
            String[] weather = serviceClient.Weather5day(zipcode);

            if (weather[0] == "Invlalid zipcode. Please try Again")
            {
                weatherOutput.Text = "Invalid zipcode. Please try Again";
            }
            else
            { 
            Table1.Visible = true;
            weatherOutput.Text = "";
            date0.Text = "DATE"; 
            condition0.Text = "WEATHER CONDITION";
            min0.Text = "MAXIMUM TEMPERATURE IN CENTIGRADES";
            max0.Text = "MINIMUM TEMPERAUTRE IN CENTIGRADES";

            
            String[] weatherOneachDay=weather[0].Split(',');
            DateTime date = DateTime.Now.AddDays(0);            
            date1.Text = date.ToString("D"); 
            condition1.Text = weatherOneachDay[0];
            min1.Text = weatherOneachDay[1];
            max1.Text = weatherOneachDay[2];
            
            weatherOneachDay=weather[1].Split(',');
            date = DateTime.Now.AddDays(1);                        
            date2.Text = date.ToString("D"); 
            condition2.Text = weatherOneachDay[0];
            min2.Text = weatherOneachDay[1];
            max2.Text = weatherOneachDay[2];

            weatherOneachDay=weather[2].Split(',');
            date = DateTime.Now.AddDays(2);
            date3.Text = date.ToString("D"); 
            condition3.Text = weatherOneachDay[0];
            min3.Text = weatherOneachDay[1];
            max3.Text = weatherOneachDay[2];

            weatherOneachDay=weather[3].Split(',');
            date = DateTime.Now.AddDays(3);
            date4.Text = date.ToString("D"); 
            condition4.Text = weatherOneachDay[0];
            min4.Text = weatherOneachDay[1];
            max4.Text = weatherOneachDay[2];

            weatherOneachDay=weather[4].Split(',');
            date = DateTime.Now.AddDays(4);
            date5.Text = date.ToString("D"); 
            condition5.Text = weatherOneachDay[0];
            min5.Text = weatherOneachDay[1];
            max5.Text = weatherOneachDay[2];
                                        
            }
        }

        }
               
}