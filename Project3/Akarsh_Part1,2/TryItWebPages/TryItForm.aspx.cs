using System;
using System.Net;
using System.Net.Http;
using System.Xml;

namespace TryItWebPages
{
    public partial class TryItForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WeatherForecastService.Service1Client forecast = new WeatherForecastService.Service1Client();
            string[] forecastDetails = forecast.WeatherForecast(TextBox1.Text);
            BulletedList1.DataSource = forecastDetails;
            BulletedList1.DataBind();
            BulletedList1.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WindService.Service1Client wind = new WindService.Service1Client();
            string windDetails = wind.WindIntensity(Decimal.Parse(TextBox2.Text),Decimal.Parse(TextBox3.Text));
            this.Label3.Text = "The wind Intesnity is:"+windDetails;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var uri = new Uri("http://webstrar43.fulton.asu.edu/page2/Service1.svc/SolarIntensity?zipcode=" + TextBox4.Text);

            var request = (HttpWebRequest)WebRequest.Create(uri);
            var response = (HttpWebResponse)request.GetResponse();


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(response.GetResponseStream());

            string averagesolarIntensity= xmlDoc.FirstChild.InnerText;
            Label6.Text = "The Solar Intensity at given Zip code is " + averagesolarIntensity;


        }
    }
}