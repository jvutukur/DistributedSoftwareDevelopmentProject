using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Project_5.StudentPages
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut();
        }

        protected void LoadAvailbleCurrenciesButton_Click(object sender, EventArgs e)
        {
            CurrencyConverterService.Service1Client currencyConverterClinet = new CurrencyConverterService.Service1Client();
            LoadAvailableCurrenciesTextBox.Enabled = true;
            LoadAvailableCurrenciesTextBox.Text = currencyConverterClinet.getCurrencyCodes();
            //LoadAvailableCurrenciesTextBox.Text = "hello";
            LoadAvailableCurrenciesTextBox.Enabled = false;
        }


        protected void ConvertAmountButton_Click(object sender, EventArgs e)
        {
            CurrencyConverterService.Service1Client currencyConverterClinet = new CurrencyConverterService.Service1Client();
            String amountInString = AmountInDollarsTextBox.Text;
            String toCurrency = ToCurrencyTextBox.Text;
            String amountInRequiredCurrency = currencyConverterClinet.CurrencyConversion(amountInString, toCurrency);
            CurrencyConveterOutputAmountTextBox.Text = Convert.ToString(amountInRequiredCurrency);

        }

        protected void EncryptionButtonInValidateCard_Click(object sender, EventArgs e)
        {

            Uri baseUri = new Uri("http://webstrar49.fulton.asu.edu/page3/Service1.svc");
            UriTemplate myTemplate = new UriTemplate("encrypt?plainText={plainText}");

            String plainText = PlainText_TextBox1.Text;
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

            cipherTextBox.Enabled = true;
            cipherTextBox.Text = cipher;
            cipherTextBox.Enabled = false;
            



        }


        protected void ValidateCardNumberButton_Click(object sender, EventArgs e)
        {

            ValidateCardNumberServie.Service1Client validateCardServiceClient = new ValidateCardNumberServie.Service1Client();
            String output = validateCardServiceClient.validateCreditCardNumber(cipherTextBox.Text);


            ValidateCardOutput.Enabled = true;
            ValidateCardOutput.Text = output;
            ValidateCardOutput.Enabled = false;
        }



        protected void makePaymentButton_Click(object sender, EventArgs e)
        {
            String amountasString = "";
            amountasString = amountasString+AmountInDollarsTextBox.Text;
            String collegeIDasString="";
            collegeIDasString = collegeIDasString + collegeIDTextBox.Text;
            String cardValidationOutput = "";
            cardValidationOutput = cardValidationOutput + ValidateCardOutput.Text;
            //Invalid Card Number
            if(!(collegeIDasString.Equals("")))
            { 
            if(!(amountasString.Equals("")))
            {
                if ((!cardValidationOutput.Equals("")) && (!cardValidationOutput.Equals("Invalid Card Number")))
            { 
           // String pathofXmlFile = HttpContext.Current.Server.MapPath(@"~\") + "\\" + "App_Data" + "\\" + "Payments.xml";
                String pathofXmlFile = Request.PhysicalApplicationPath + "App_Data" + "\\" + "Payments.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathofXmlFile);

      

            XmlNode payment=xmlDoc.CreateElement("Payment"); //created a node Payment
            XmlNode colID=xmlDoc.CreateElement("CollegeID");
            colID.InnerText=collegeIDasString;
            payment.AppendChild(colID);
            XmlNode amount=xmlDoc.CreateElement("AmountInDollars");
            amount.InnerText=amountasString;
            payment.AppendChild(amount);

            
            xmlDoc.DocumentElement.AppendChild(payment);
            int count = xmlDoc.SelectNodes("//AllPayments/Payment").Count;
            xmlDoc.Save(pathofXmlFile);
            
            FailureText.Text = "Payment Succesful. Record Number is "+ count;
            ErrorMessage.Visible = true;
            collegeIDTextBox.Text = "";
            LoadAvailableCurrenciesTextBox.Enabled = true;
            LoadAvailableCurrenciesTextBox.Text = "";
            LoadAvailableCurrenciesTextBox.Enabled = false;
            AmountInDollarsTextBox.Text = "";
            ToCurrencyTextBox.Text = "";
            CurrencyConveterOutputAmountTextBox.Text = "";
            PlainText_TextBox1.Text = "";
            cipherTextBox.Text = "";
            ValidateCardOutput.Text = "";

            }
            else
            {
                FailureText.Text = "Please give a valid card number and get validation";
                ErrorMessage.Visible = true;
            }

            }
            else
            {
                FailureText.Text = "Enter valid Amount in Dollars Field. Empty is not valid amount";
                ErrorMessage.Visible = true;
            }
            }
            else
            {
                FailureText.Text = "Enter Valid data in College ID filed or Empty is not a valid data";
                ErrorMessage.Visible = true;
            }

        }
    }
}