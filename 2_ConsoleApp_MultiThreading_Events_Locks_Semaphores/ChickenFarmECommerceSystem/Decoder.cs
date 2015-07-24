using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenFarmECommerceSystem
{
    class Decoder
    {
        public static Order convertStringToObject(String encodedOrder)
        {
            Order decodedOrderObj = new Order();
            try
            {                        
            String[] orderVariables = encodedOrder.Split('#');
            decodedOrderObj.setSenderId(orderVariables[0]);
            decodedOrderObj.setCardNum(int.Parse(orderVariables[1]));
            decodedOrderObj.setNumOfChicken(int.Parse(orderVariables[2]));
            decodedOrderObj.setStartTime (TimeSpan.Parse(orderVariables[3]));           
                }
            catch(Exception e)
            {

            }
            return decodedOrderObj;
        }
    }
}
