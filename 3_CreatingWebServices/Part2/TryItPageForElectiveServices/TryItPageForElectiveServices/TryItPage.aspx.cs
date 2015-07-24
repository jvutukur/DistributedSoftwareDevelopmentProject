using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;

namespace TryItPageForElectiveServices
{
    public partial class TryItPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void ConvertAmountButton_Click(object sender, EventArgs e)
        {
            CurrencyConverterService.Service1Client currencyConverterClinet = new CurrencyConverterService.Service1Client();
            String amountInString = AmountInDollarsTextBox.Text;
            String toCurrency=ToCurrencyTextBox.Text;
            String amountInRequiredCurrency=currencyConverterClinet.CurrencyConversion(amountInString, toCurrency);
            CurrencyConveterOutputAmountTextBox.Text = Convert.ToString(amountInRequiredCurrency);

        }

        protected void LoadAvailbleCurrenciesButton_Click(object sender, EventArgs e)
        {
            CurrencyConverterService.Service1Client currencyConverterClinet = new CurrencyConverterService.Service1Client();
            LoadAvailableCurrenciesTextBox.Enabled = true;
            LoadAvailableCurrenciesTextBox.Text = currencyConverterClinet.getCurrencyCodes();
            //LoadAvailableCurrenciesTextBox.Text = "hello";
            LoadAvailableCurrenciesTextBox.Enabled = false;
        }

        protected void EncryptionButton_Click(object sender, EventArgs e)
        {

            // Using Restful Service 
            //"http://webstrar49.fulton.asu.edu/page3/Service1.svc/encrypt?plainText=abcd";

            Uri baseUri = new Uri("http://webstrar49.fulton.asu.edu/page3/Service1.svc");
            UriTemplate myTemplate = new UriTemplate("encrypt?plainText={plainText}");
            
            String plainText = PlainText_TextBox.Text;
            Uri completeUri = myTemplate.BindByPosition(baseUri, plainText);

            System.Net.WebClient webClient = new System.Net.WebClient();            
            byte[] content = webClient.DownloadData(completeUri);


            //EncryptionService.Service1Client encryptionClient = new EncryptionService.Service1Client();            
            // String cipher=encryptionClient.encrypt(plainText);

            String contentinString = Encoding.UTF8.GetString(content, 0, content.Length);

            String pattern=@"(?<=\>)(.*?)(?=\<)"; 
            Regex r= new Regex(pattern);
            Match m = r.Match(contentinString);

            String cipher="";
            if(m.Success)
            {
             cipher = m.Groups[1].ToString();
            }

            
            
            
            EncryptionOutput.Enabled = true;            
           EncryptionOutput.Text = cipher;
            EncryptionOutput.Enabled = false;
         Cipher_TextBox.Text = cipher;
            Cipher_TextBox.Enabled = false;
        }

        protected void DecryptionButton_Click(object sender, EventArgs e)
        {
            CurrencyConverterService.Service1Client decryptionClient = new CurrencyConverterService.Service1Client();
            String cipher = Cipher_TextBox.Text;
            String plainText = decryptionClient.decryption(cipher);
            DecryptionOutput.Text = plainText;
        }

        protected void EncryptionButtonInValidateCard_Click(object sender, EventArgs e)
        {

            Uri baseUri = new Uri("http://webstrar49.fulton.asu.edu/page3/Service1.svc");
            UriTemplate myTemplate = new UriTemplate("encrypt?plainText={plainText}");

            String plainText = PlainText_TextBox.Text;
            Uri completeUri = myTemplate.BindByPosition(baseUri, plainText);

            System.Net.WebClient webClient = new System.Net.WebClient();
            byte[] content = webClient.DownloadData(completeUri);


            //EncryptionService.Service1Client encryptionClient = new EncryptionService.Service1Client();            
            // String cipher=encryptionClient.encrypt(plainText);

            String contentinString = Encoding.UTF8.GetString(content, 0, content.Length);

            String pattern = @"(?<=\>)(.*?)(?=\<)";
            Regex r = new Regex(pattern);
            Match m = r.Match(contentinString);

            String cipher = "";
            if (m.Success)
            {
                cipher = m.Groups[1].ToString();
            }

            
            PlainText_TextBox1.Text = cipher;
           // EncryptionOutputInCard.Enabled = true;
            //EncryptionOutputInCard.Text = cipher;
            //EncryptionOutputInCard.Enabled = false;
            
            
          
        }

        protected void ValidateCardNumberButton_Click(object sender, EventArgs e)
        {           
          
            ValidateCardNumberServie.Service1Client validateCardServiceClient=new ValidateCardNumberServie.Service1Client();
            String output = validateCardServiceClient.validateCreditCardNumber(PlainText_TextBox1.Text);


            ValidateCardOutput.Enabled = true;
            ValidateCardOutput.Text = output;
            ValidateCardOutput.Enabled = false;
        }

       

        
    }
}