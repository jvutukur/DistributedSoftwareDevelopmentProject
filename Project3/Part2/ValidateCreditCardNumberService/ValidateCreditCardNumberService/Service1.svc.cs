using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ValidateCreditCardNumberService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       public string validateCreditCardNumber(String encryptedCardNumber)
        {
            // got to know the alogrithm from http://www.freeformatter.com/credit-card-number-generator-validator.html
           
           /* Sample VISA Card Numbers to validate
            4539796436057777
            4539933958334223
            4929304928715883 
            */


            /* Sample Master Card Numbers to validate
             5243017734757255
             5276351631949081
             5221747122502766             
             */


            /* Sample American Express Card Numbers to validate
             378952905599037
             348854828703935
             349461414713796
             */

            Boolean isCardValid = false;
            String cardType;

            byte[] creditCardNumberInBytes = new Byte[20];

           DecryptionService.Service1Client decryptionServiceClient =new DecryptionService.Service1Client();
           String decryptedCardNumber = decryptionServiceClient.decryption(encryptedCardNumber);

           String cardNumberasString=decryptedCardNumber; //decrypting the encrypted card Number

           int length = 0;

           for(int i=0;i<cardNumberasString.Length;i++)
           {
               if(char.IsDigit(cardNumberasString,i))
               {                   
                   creditCardNumberInBytes[length] = byte.Parse(cardNumberasString[i].ToString());
                   length++;

                   if(length==19)
                   {
                       break;
                   }
               }
           }

           if (length != 16)
               isCardValid = false;

           int sumofDigits=0;
           if(length==16)
           {
               for( int i=0; i<length-1;i++) //0 to 14 .. total 15 values
               {
                   if((i%2==0)) //will go into this if block only for the odd position of card number
                   { 
                       //taking only odd places of card number and multiplying number with 2 
                       int value = (creditCardNumberInBytes[i] * 2);

                       //if value greater than 9 substract 9 from value
                       if (value > 9)
                           value = value - 9;

                       sumofDigits = sumofDigits + value;
                   }
                   else
                   {
                       sumofDigits = sumofDigits + creditCardNumberInBytes[i];
                   }

               }

               if (sumofDigits % 10 == creditCardNumberInBytes[15])
                   isCardValid = true;
           }

           if(isCardValid==true)
           {

               switch(cardNumberasString.Substring(0,1))
               {
                   case "3":
                       cardType = "American Express or Dinners Club or JCB";
                       break;
                   case "4":
                       cardType = "Visa";
                       break;
                   case "5":
                       cardType = "Diners Club or Master Card ";
                       break;
                   case "6":
                       cardType = "Discover or InstalPayment or Laser";
                       break;
                   default:
                       cardType = "Card Num is valid but cannot say the bank name";
                       break;
               }

           }
           else
           {
               cardType = "Invalid Card Number";
           }

           return cardType;

        }
    }
}
