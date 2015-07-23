using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SolarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string getSolarIntensity(string zipCode)
        {
            string query = string.Format("http://iaspub.epa.gov/enviro/efservice/getEnvirofactsUVDAILY/ZIP/{0}", zipCode);
            XmlDocument xData = new XmlDocument();
            xData.Load(query);
            string res = "";
            res += xData.GetElementsByTagName("UV_INDEX")[0].InnerText + "<br>";
            return res;

            //0-5 is moderate
            //6-8 is high
            //above 8 better stay inside
        }
    }
}
