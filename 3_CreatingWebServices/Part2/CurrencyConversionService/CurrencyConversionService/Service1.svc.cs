using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Windows;
using System.IO;
namespace CurrencyConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public String CurrencyConversion(String amountInString, String toCurrency)
        {
            CurrencyConvertor_Webervicex_asmxService.CurrencyConvertor serviceClient = new CurrencyConvertor_Webervicex_asmxService.CurrencyConvertor();
            double amount;
            try
            {
                amount = Convert.ToDouble(amountInString);
            }
            catch (Exception e)
            {
                amount = 0;
            }
            CurrencyConvertor_Webervicex_asmxService.Currency from;
            CurrencyConvertor_Webervicex_asmxService.Currency to;

            from = CurrencyConvertor_Webervicex_asmxService.Currency.USD;
            to = CurrencyConvertor_Webervicex_asmxService.Currency.USD;
            int flag = 0;
            switch (toCurrency)
            {
                case "INR":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "JPY":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "GBP":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "CHF":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "CAD":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "AUD":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "ZAR":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "KYD":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "EUR":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                case "CNY":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.INR;
                    break;
                default:
                    flag = 1;
                    break;
            }

            double rate;
            if (flag != 1)
                rate = serviceClient.ConversionRate(from, to);
            else
                rate = 0;
            double amountInNewCurrency = amount * rate; //if amountInNewCurrency is zero it means currency not found or amount is not valid 

            String amountInNewCurrencyInString;
            if (amountInNewCurrency != 0)
                amountInNewCurrencyInString = Convert.ToString(amountInNewCurrency);
            else
                amountInNewCurrencyInString = "Error Occured Please give valid amount and valid currency Id which we support.\n example amount: 125 and currency: INR";
            return amountInNewCurrencyInString;

        }

        public String getCurrencyCodes()
        {
            String currencyCodes = "";
            try
            {                
                //String fileName = "../CurrencyCodes_Few.txt";
              String fileName="Data/abc.txt";
                StreamReader sr = new StreamReader(fileName);
                currencyCodes = sr.ReadToEnd();
            }
            catch(Exception e)
            {
                
                
                currencyCodes = "file not found";
            }
            
            currencyCodes = "INR-Indian Rupee\n"+
                            "PY-Japanese\n"+ 
                            "YenGBP-British\n" +
                            "PoundCHF-Swiss\n" +
                            "FrancCAD-Canadian\n"+ 
                            "DollarAUD-Australian\n"+ 
                            "DollarZAR-South African\n" + 
                            "RandKYD-Cayman Islands\n" + 
                            "DollarEUR-Euro\n" +
                            "CNY-Chinese Yuan\n";
            return currencyCodes;

        }
    }
}
