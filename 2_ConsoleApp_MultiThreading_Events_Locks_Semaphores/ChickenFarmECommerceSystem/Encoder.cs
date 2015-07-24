using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenFarmECommerceSystem
{
    class Encoder
    {
        public static String convertObjectToString(Order orderObj)
        {
            String encodedOrder;
            encodedOrder = orderObj.getSenderId() + "#" + orderObj.getCardNum().ToString() + "#" + orderObj.getNumOfChicken().ToString()+"#"+orderObj.getStartTime();
            
            return encodedOrder;            

        }
    }
}
