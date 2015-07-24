using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenFarmECommerceSystem
{
    class Order
    {

        private String senderId;
        private int cardNum;
        private int  numOfChicken;                
        private TimeSpan startTime;
        private TimeSpan endTime;        
        
        public String message;

        public TimeSpan getStartTime()
        {
            return this.startTime;
        }

        public TimeSpan getEndTime()
        {
            return this.endTime;
        }
        public void setStartTime(TimeSpan startTime)
        {
            this.startTime=startTime;
        }
        public void setEndTime(TimeSpan endTime)
        {
            this.endTime=endTime;
        }
        public String getSenderId()
        {
            return this.senderId;
        }
        public void setSenderId(string senderId)
        {
            this.senderId = senderId;
        }


        public int getCardNum()
        {
            return this.cardNum;
        }        
        public void setCardNum(int cardNum)
        {
            this.cardNum = cardNum;
        }
        
        
        public void setNumOfChicken(int numOfChicken)
        {
            this.numOfChicken = numOfChicken;
        }

        public int getNumOfChicken()
        {
            return this.numOfChicken;
        }
        
       
    }
}
