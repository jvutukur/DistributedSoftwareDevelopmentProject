using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_TempConversionWindowsFormApp
{
    public partial class TempConversionForm : Form
    {
        public TempConversionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
            TemperatureConcersionService.Service1Client serviceObj = new TemperatureConcersionService.Service1Client();
            int celsius = int.Parse(textBox1.Text);
            String value = serviceObj.c2f(celsius).ToString();
            label3.Text = "Temperature in Fahrenhiet is : " + value; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TemperatureConcersionService.Service1Client serviceObj = new TemperatureConcersionService.Service1Client();
            String value = serviceObj.f2c(int.Parse(textBox2.Text)).ToString();
            label4.Text = "Temperature in Celsius is : " + value;
        }
    }
}
