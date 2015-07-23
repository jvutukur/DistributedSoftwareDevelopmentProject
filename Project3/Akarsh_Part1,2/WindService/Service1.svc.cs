using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;


namespace WindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string WindIntensity(decimal latitude, decimal longitude)
        {
           /* WindAPI.ndfdXML getWeatherData = new WindAPI.ndfdXML();
            string latLon = getWeatherData.LatLonListZipCode(zipCode);
            var xmlIn = XDocument.Parse(latLon);
            string temperatureList = xmlIn.Element("dwml").Value;
            string[] latLonValues = temperatureList.Split(',');
            decimal latitude = Decimal.Parse(latLonValues[0]);
            decimal longitude = Decimal.Parse(latLonValues[1]);*/
            try
            {
                Console.WriteLine(latitude);

                string getWindData = string.Format("http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&mode=xml", latitude, longitude);
                XmlDocument windData = new XmlDocument();
                windData.Load(getWindData);
                XmlNode data = windData.SelectSingleNode("//current/wind/speed");
                string res = data.Attributes["value"].Value;
                decimal result = Convert.ToDecimal(res);
                return result.ToString();
            }
            catch(Exception e)
            {
                return "0";
            }
        }
    }
}
