using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace WeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] WeatherForecast(string zipcode)
        {
            string[] tempList = new string[5];
            

                WeatherAPI.ndfdXML getWeatherData = new WeatherAPI.ndfdXML();
                string latLon = getWeatherData.LatLonListZipCode(zipcode);
                var xmlIn = XDocument.Parse(latLon);
                string temperatureList = xmlIn.Element("dwml").Value;
                string[] latLonValues = temperatureList.Split(',');
                decimal latitude = Decimal.Parse(latLonValues[0]);
                decimal longitude = Decimal.Parse(latLonValues[1]);
                string temperatureValues = getWeatherData.NDFDgenByDay(latitude, longitude, DateTime.Now, "5", "e", "24 hourly");
                XmlDocument weatherDoc = new XmlDocument();
                weatherDoc.LoadXml(temperatureValues);

                var temperaturesList = weatherDoc.GetElementsByTagName("temperature");
                var weatherCondList = weatherDoc.GetElementsByTagName("weather")[0].SelectNodes("weather-conditions");
                var minimimTemperature = temperaturesList[0].SelectNodes("value");
                var maximumTemperature = temperaturesList[1].SelectNodes("value");


                for (int i = 0; i < 5; i++)
                {
                    int a = i + 1;
                    tempList[i] = "Day" + a + ": Maximum Temperature-" + minimimTemperature[i].InnerText + "   Minimum Temperature-" + maximumTemperature[i].InnerText + "   Weather Condition-" + weatherCondList[i].Attributes[0].InnerText;
                }
            }
            
            return tempList;
        }
    }
}
