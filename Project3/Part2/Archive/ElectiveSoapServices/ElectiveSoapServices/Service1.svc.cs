using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ElectiveSoapServices
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
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.JPY;
                    break;
                case "GBP":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.GBP;
                    break;
                case "CHF":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.CHF;
                    break;
                case "CAD":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.CAD;
                    break;
                case "AUD":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.AUD;
                    break;
                case "ZAR":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.ZAR;
                    break;
                case "KYD":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.KYD;
                    break;
                case "EUR":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.EUR;
                    break;
                case "CNY":
                    to = CurrencyConvertor_Webervicex_asmxService.Currency.CNY;
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
           /*
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
            */
            currencyCodes = "INR-Indian Rupee\n"+
                            "JPY-Japanese\n"+
                            "GBP-British Yen\n" +
                            "CHF-Swiss Pound\n" +
                            "CAD-Canadian Franc\n" +
                            "AUD-Australian Dollar\n" +
                            "ZAR-South African Dollar\n" +
                            "KYD-Cayman IslandsRand\n" +
                            "EUR-Euro Dollar\n" +
                            "CNY-Chinese Yuan\n";
            return currencyCodes;

        }


        public String decryption(String cipher)
        {
            String key = "DSOD";
            byte[] key32Bit = Encoding.UTF8.GetBytes(key);
            String plainText = "";
            byte[] cipherInByteArray = Encoding.UTF8.GetBytes(cipher);


            for (int i = 0; i < cipher.Length; i += 4)
            {
                byte[] input32Bit;

                if (cipher.Length > i + 3)
                    input32Bit = new byte[] { cipherInByteArray[i], cipherInByteArray[i + 1], cipherInByteArray[i + 2], cipherInByteArray[i + 3] };
                else if (cipher.Length == i + 3)
                    input32Bit = new byte[] { cipherInByteArray[i], cipherInByteArray[i + 1], cipherInByteArray[i + 2], 0 };
                else if (cipher.Length == i + 2)
                    input32Bit = new byte[] { cipherInByteArray[i], cipherInByteArray[i + 1], 0, 0 };
                else
                    input32Bit = new byte[] { cipherInByteArray[i], 0, 0, 0 };

                byte[] output32Bit = blockDecryption(input32Bit, key32Bit);
                String output32BitInString = Encoding.UTF8.GetString(output32Bit, 0, output32Bit.Length);
                plainText = plainText + output32BitInString;

            }


            return plainText;
        }


        public byte[] blockDecryption(byte[] input32Bit, byte[] key32Bit)
        {
            byte[] output32Bit = new byte[4];


            for (int i = 0; i < 4; i++)
            {
                output32Bit[i] = (byte)(input32Bit[i] ^ key32Bit[i]);
            }
            return output32Bit;


        }

        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
