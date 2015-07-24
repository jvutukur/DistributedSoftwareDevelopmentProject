using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChickenFarmECommerceSystem
{
    class MyApplication
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(180, 300);    //Making console to store 300 lines of values

            Console.WriteLine("\n                      Chicken Farm E Commerce System");
            Console.WriteLine("                     MultiBuffer Cell Size is 3");
            Console.WriteLine("                     Intially price of chicken is 5");
            Console.WriteLine("                     Number of Retailer Threads are 5\n\n");
            ChickenFarm.priceCut += new ChickenFarm.priceCutEventHandler(Retailers.onPriceCut);
            
            ChickenFarm chickenFarm = new ChickenFarm();
            Thread chickenFarmThread=new Thread(new ThreadStart(ChickenFarm.farmerFunc)) ;            //creating a thread for Chicken farm
            chickenFarmThread.Name = "ChickenFarm"; //giving a name to thread created for chicen farm
                                
            
            int numberOfRetailers=5;

            Thread[] retailers=new Thread[numberOfRetailers];
            for(int i=0;i<numberOfRetailers;i++) //creating and starting 5 retailer threads
            {
                retailers[i]=new Thread(new ThreadStart(Retailers.retalierFunc));
                retailers[i].Name= "Retailer"+(i+1).ToString();
                retailers[i].Start();
            }

            chickenFarmThread.Start(); //starting the Chicken farm thread
            chickenFarmThread.Join();  //Waiting for the chicken farm thread to complete its execution. Chicken farm execution will be completed afer 5 times price cut event happens

            //Aborting all Retailer Threads
            for(int i=0;i<numberOfRetailers;i++)
            {
                retailers[i].Abort();
            }

            Console.Write("\n\nPrice Cut Count Reached to 5. So Terminated Chicken Farm and Retailer Threads and orders after recent price change will be discarded\n\n\n");
            
        }
    }
}
