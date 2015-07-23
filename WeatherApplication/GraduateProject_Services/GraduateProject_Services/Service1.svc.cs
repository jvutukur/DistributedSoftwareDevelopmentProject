using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace GraduateProject_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string[] Weather5day(String zipcode)
        {
            String[] output=new String[6];
         try{
            //Calculating Latitude and Longitude values from the zipcode
             WeatherServiceClient.ndfdXML serviceClinet= new WeatherServiceClient.ndfdXML();
            String latitudeLongitudeXMLDocasString = serviceClinet.LatLonListZipCode(zipcode);

            var xdoc = XDocument.Parse(latitudeLongitudeXMLDocasString);
            String latLonlist = xdoc.Element("dwml").Value;
            String[] latLongArray=latLonlist.Split(',');
            decimal latitude = decimal.Parse(latLongArray[0]);
            decimal longitute = decimal.Parse(latLongArray[1]);


            //Calculating weather based on obtained latitude and longitude values
            String temperaturefor5daysinString = serviceClinet.NDFDgenByDay(latitude, longitute, DateTime.Now, "6", "m", "24 hourly");
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(temperaturefor5daysinString);

            var tempList = xmldoc.GetElementsByTagName("temperature");
            var weatherConditionList = xmldoc.GetElementsByTagName("weather")[0].SelectNodes("weather-conditions");
            var minTempList=tempList[0].SelectNodes("value");
            var maxTempList=tempList[1].SelectNodes("value");
    
            for(int i=0;i<5;i++)
            {
                output[i]=weatherConditionList[i].Attributes[0].InnerText+","+minTempList[i].InnerText+","+maxTempList[i].InnerText; 
            }
        }
            catch(Exception e)
            {
                output[0] = "Invlalid zipcode. Please try Again";
            }
            return output;
        }

        public string get_UV_Index(String zipcode)
        {
            String uvIndex = "";
            try
            {


                Uri baseUri = new Uri("http://iaspub.epa.gov/enviro/efservice/getEnvirofactsUVDAILY");
                UriTemplate myTemplate = new UriTemplate("/ZIP/{zipCode}");
                Uri completeUri = myTemplate.BindByPosition(baseUri, zipcode);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(completeUri.ToString());



                uvIndex =uvIndex+ xmlDoc.GetElementsByTagName("UV_INDEX")[0].InnerText;

                int indexAsInt = Int32.Parse(uvIndex);
                
                if(uvIndex=="")
                {
                    uvIndex="Invalid zipcode. Please try againg";
                }
                else if(indexAsInt<=5)
                {
                    
                    uvIndex = "Uv Index value is " + uvIndex + " \n 0-5 is moderate";
                }
                else if(indexAsInt<=8)
                {
                    
                    //6-8 is high
                    uvIndex = "Today UV Index value in this location is " + uvIndex + "  (6-8 is high)";
                }
                else
                {
                    //above 8 better stay inside
                    uvIndex = "UV Index value in this location is " + uvIndex + " ( 8-11 is very high take necessary precautions)";
                }
                //A character indicating if there is a UV Index alert issued for this area on the forecast day.

                
                
                
            }
            catch(Exception e)
            {

            }
            return uvIndex;

        }
          
        public String[] WindIntensity(String zipcode, String countryCode)
        {
            String[] windIntensity = new String[5];

            try
            {
                //http://api.openweathermap.org/data/2.5/weather?zip=85281,US&mode=xml                                   
                Uri baseUri = new Uri("http://api.openweathermap.org/data/2.5");
                zipcode = zipcode + ","+countryCode;
                UriTemplate myTemplate = new UriTemplate("/weather?zip={zipcode}&mode=xml");
                Uri completeUri = myTemplate.BindByPosition(baseUri, zipcode);                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(completeUri.ToString());

                //name of location
                XmlNode location = xmlDoc.SelectSingleNode("//current/city");
                windIntensity[0] = location.Attributes["name"].Value;

                XmlNode co_ord=xmlDoc.SelectSingleNode("//current/city/coord");
                windIntensity[1]=co_ord.Attributes["lat"].Value;
                windIntensity[2] = co_ord.Attributes["lon"].Value;
                
                XmlNode windSpeed=xmlDoc.SelectSingleNode("//current/wind/speed");;
                windIntensity[3] = windSpeed.Attributes["name"].Value + " ( " + windSpeed.Attributes["value"].Value + " )";

                XmlNode windDirection = xmlDoc.SelectSingleNode("//current/wind/direction");
                windIntensity[4] = windDirection.Attributes["name"].Value;


            }
            catch(Exception e)
            {
                windIntensity[0] = "Invalid input. Please try again";
            }
            return windIntensity;
        }


    }
}
