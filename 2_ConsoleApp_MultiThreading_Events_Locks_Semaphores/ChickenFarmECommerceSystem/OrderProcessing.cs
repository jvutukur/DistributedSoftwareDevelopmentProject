using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ChickenFarmECommerceSystem
{
    class OrderProcessing
    {
        static int taxPercentage = 8, shippingChargePercentage=8;
        public static void processOrder(Order decodedOrderObj,int chickenPrice)
        {
            
            if(validCardNumber(decodedOrderObj)) //validing the credit card number given by the retiler
            {
                
                int billingAmount=(decodedOrderObj.getNumOfChicken()*chickenPrice)*(1+(taxPercentage/100)+(shippingChargePercentage/100));                
                decodedOrderObj.setEndTime(DateTime.Now.TimeOfDay);
                decodedOrderObj.message="       "+decodedOrderObj.getSenderId()+" is notified after processing order of "+decodedOrderObj.getNumOfChicken()+" chicken requested at "+decodedOrderObj.getStartTime()+" and  billing amount is $"+billingAmount+" now time is "+decodedOrderObj.getEndTime();

                
            }
            else
            {

                decodedOrderObj.message = "     " +decodedOrderObj.getSenderId() + " is notified after processing order of " + decodedOrderObj.getNumOfChicken() + " chicken requested at "+decodedOrderObj.getStartTime()+". This order is discarded because of invalid card number" + " now time is " + decodedOrderObj.getEndTime();
                
            }
            
            ChickenFarm.orderProcessReceipt(decodedOrderObj);
        }
        
        public static Boolean validCardNumber(Order decodedOrderObj)
        {
            if(decodedOrderObj.getCardNum()>5000 && decodedOrderObj.getCardNum()<7000)
            return true;
            else return false;
        }
    }
}
