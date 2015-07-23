using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;

namespace TryItPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void ValidateButton_Click(object sender, EventArgs e)
        {
            XMLServiceReference.Service1Client serviceclient = new XMLServiceReference.Service1Client();
            ValidateOutput.Enabled = true;
            ValidateOutput.Text = serviceclient.verification(xmlurlTextBox.Text, xsdurlTextBox.Text);
            ValidateOutput.Enabled = false;
        }
        
        protected void TransformButton_Click(object sender, EventArgs e)
        {
            XMLServiceReference.Service1Client serviceclient = new XMLServiceReference.Service1Client();
            ValidateOutput.Enabled = true;
            String htmlcontentasString=serviceclient.transformation(xmlurlTransformTextBox.Text, xslurlTextBox.Text);
            TransformOutput.Text = htmlcontentasString;
                
            ValidateOutput.Enabled = false;

            String path =@"D:/Persons.html";
            if(!File.Exists(path))
            {
                //create a new file and write into it
                File.WriteAllText(path, htmlcontentasString);                
            }
            else
            {
                File.Delete(path);
                File.WriteAllText(path, htmlcontentasString);                
            }
            
            /*catch(Exception ex)
            {
            }
             */
        }

        
    }
}