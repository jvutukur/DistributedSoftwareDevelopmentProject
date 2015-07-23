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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FindUVIndexButton_Click(object sender, EventArgs e)
        {
            GraduateProjectServices.Service1Client servicesClient = new GraduateProjectServices.Service1Client();
            String zipCode = uv_zipcodeTextBox1.Text;
            try
            {
                String uv_Output = servicesClient.get_UV_Index(zipCode);
                if(uv_Output=="")
                {
                    uv_Output = "Invalid zipcode. Please try againg";
                }
                UV_IndexOutput.Text = uv_Output;
            }
            catch(Exception ex)
            {

            }

        }

        
    }
}