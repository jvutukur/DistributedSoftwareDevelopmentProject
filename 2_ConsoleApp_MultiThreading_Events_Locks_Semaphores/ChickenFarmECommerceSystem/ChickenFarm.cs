using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ChickenFarmECommerceSystem
{
    class ChickenFarm
    {
        private static Int32 chickenPrice = 5;  
        
        public static ReaderWriterLock rw = new ReaderWriterLock();
        static Random rng = new Random();
        static int priceCutCount = 0;  
        public static int countToChangePrice = 0;
        public delegate void priceCutEventHandler(Int32 newPrice); //Defined a delgate
        public static event priceCutEventHandler priceCut; // Defined an event based on delegate

        public Int32 getPrice() 
        {
            return chickenPrice;
        }


        public static void orderProcessReceipt(Order processedObj)   
        {
            
            Console.WriteLine(processedObj.message);
        }

        public static int pricingModel()
        {
            return rng.Next(5, 15);
        }

        public static void farmerFunc()
        {
            
            while (priceCutCount < 5)     //execution of this method occurs till 5 times price cut event is triggered
            {
                String encodedOrder = MultiBufferCell.getOneCell();  //Chicken farm gets the order from Multibuffer cell
                
                Order decodedOrderobj = Decoder.convertStringToObject(encodedOrder);               //Decodes the encoded order using decoder
                countToChangePrice++;

                // Calculates new price of chicken after getting 4 orders
                Thread orderProcessingThread = new Thread(() => OrderProcessing.processOrder(decodedOrderobj, chickenPrice));
                orderProcessingThread.Start();                //starting a new thread for each order

                if (countToChangePrice % 4 == 0 && countToChangePrice!=0)
                {
                    rw.AcquireWriterLock(Timeout.Infinite);
                    try { 
                    Retailers.flag = false;   
                    //{
                    int oldchickenPrice = chickenPrice;
                    int newChickenPrice = pricingModel();    //using pricing model to calculate new price of chicken
                    Console.WriteLine("\n\n\n                             Chicken Farm changed Price from {0} to {1}\n", chickenPrice, newChickenPrice);
                    chickenPrice = newChickenPrice;
                    if (newChickenPrice < oldchickenPrice)
                    {
                        priceCutCount++;
                        if (priceCut != null)
                        {
                            priceCut(newChickenPrice);  //notifying methods subscribed to PriceCut Event
                        }
                    }
                        }
                    finally { rw.ReleaseWriterLock(); }
                    //}
                    
                }                               
            }
            
            

        }
    }
}
