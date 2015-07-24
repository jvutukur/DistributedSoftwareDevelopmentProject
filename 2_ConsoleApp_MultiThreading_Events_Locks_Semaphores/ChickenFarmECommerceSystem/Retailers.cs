using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChickenFarmECommerceSystem
{
    class Retailers
    {
        public static Random rng = new Random();
        public static Boolean flag=false;
        public static ReaderWriterLock rw = new ReaderWriterLock();
        public static void retalierFunc()
        {
            while (true)
            {
                Order orderObj = new Order();
                orderObj.setSenderId(Thread.CurrentThread.Name);
                orderObj.setCardNum(rng.Next(4800, 6999));

                rw.AcquireReaderLock(Timeout.Infinite);
                try{

                    if (flag)  //flag value is based on event. So Retilers actions are based on pricecut event
                    {
                        orderObj.setNumOfChicken(rng.Next(50, 70));
                    }
                    else
                    {
                        orderObj.setNumOfChicken(rng.Next(10, 20));
                    }
                }
                finally { rw.ReleaseReaderLock(); }
                
                orderObj.setStartTime(DateTime.Now.TimeOfDay);
                string encodedObject = Encoder.convertObjectToString(orderObj);

                MultiBufferCell.setOneCell(encodedObject);

                Console.WriteLine("{0} gave an order of {1} chickens", Thread.CurrentThread.Name, orderObj.getNumOfChicken());
                Thread.Sleep(750);
            }
            }
        
        public static  void onPriceCut(int price) //call back method for the subscribed event
        {
            rw.AcquireWriterLock(Timeout.Infinite);
            try{
            Console.WriteLine("\nNotification reached to methods  subscribed to priceCut Event\n");
            flag=true;
                }
            finally
            {
                rw.ReleaseWriterLock();
            }
        }
        
       
    }
}
