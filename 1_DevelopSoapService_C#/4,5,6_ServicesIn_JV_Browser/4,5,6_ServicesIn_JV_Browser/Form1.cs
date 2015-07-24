using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_5_6_ServicesIn_JV_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textURL.Text);
        }

        //encryption
        private void button2_Click(object sender, EventArgs e)
        {
            EncryptDecryptService.ServiceClient encObj=new EncryptDecryptService.ServiceClient();
            String input=textBox1.Text;
            String output=encObj.Encrypt(input);
            label6.Text="Encrypted value of "+input+" is "+output;
            textBox2.Text = output;
        }

        //decryption
        private void button3_Click(object sender, EventArgs e)
        {
            EncryptDecryptService.ServiceClient decObj=new EncryptDecryptService.ServiceClient();
            String input=textBox2.Text;
            try
            {
                String output=decObj.Decrypt(input);            
                label7.Text = "Decrypted value of " + input + " is " + output;
            }
            catch
            {
                label7.Text = "Please Enter a valid Text. Input given by you is invalid";
            }
        }
       
        //Stock Quote
        private void button4_Click(object sender, EventArgs e)
        {
            StockQuoteService.ServiceClient stockObj = new StockQuoteService.ServiceClient();
            String input = textBox3.Text;
            String output=stockObj.getStockquote(input);
            label8.Text="Stock Quote Value of "+input+" is "+output;
        }

        
    }
}
