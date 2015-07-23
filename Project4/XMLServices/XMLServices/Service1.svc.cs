using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

namespace XMLServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
         String verficationOutput="";
         int count = 0;
        public String verification(string xmlurl, String xsdurl)
        {

            //"http://www.public.asu.edu/~jvutukur/DSOD/Persons.xsd"
            //"http://www.public.asu.edu/~jvutukur/DSOD/Persons.xml"
            try
            {
                XmlSchemaSet sc = new XmlSchemaSet();
                sc.Add(null,xsdurl);

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = sc;
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

                XmlReader reader = XmlReader.Create(xmlurl, settings);

                while (reader.Read()) ;

                if(count==0)
                    verficationOutput = verficationOutput + "No errors in the xml. " + "The XML file validaton has completed";
                else
                verficationOutput = verficationOutput + "\n\nThe XML file validaton has completed";

            }
            catch(Exception ex)
            {
                verficationOutput = verficationOutput+ex.Message;
            }
            
            
            return verficationOutput;


        }
        
        public void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            count++;
            verficationOutput = verficationOutput + e.Message + "\n\n";
        }

        public string transformation(String xmlurl, String xslurl)
        {
            
            try
            {                
                XPathDocument doc = new XPathDocument(xmlurl);
                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(xslurl);
                
                StringWriter sw=new System.IO.StringWriter();
                xt.Transform(doc,null,sw);
                return sw.ToString();

            }
            catch(Exception ex)
            {
                return "encountered an exception. Please try again";
            }

        }

    }
}
