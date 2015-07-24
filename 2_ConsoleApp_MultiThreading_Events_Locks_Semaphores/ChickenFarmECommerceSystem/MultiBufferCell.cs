using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChickenFarmECommerceSystem
{
    class MultiBufferCell
    {
       //size of bufferCell is 3
        static int bufferSize=3;
        static string[] buffer=new string[bufferSize]; 
        static int  front_read=-1;
        static int rear_write=-1;
        //number of cells is less than max Number of Retailers
        //using semaphores and locking mechanism to manage less resourses than resource requesters
        static Semaphore writeSem= new Semaphore(3,3);
        static Semaphore readSem = new Semaphore(0, 3);
    
        public static void setOneCell(string encodedObject)
        {

            writeSem.WaitOne(); //wait until buffer has atleast one space in it
            ReaderWriterLock rw = new ReaderWriterLock();
            rw.AcquireWriterLock(Timeout.Infinite);
            try{      // writing into buffer --- circular queue
                if(rear_write==bufferSize-1)
                    rear_write=0;
                else
                    rear_write=rear_write+1;
            
                buffer[rear_write]=encodedObject;        
                
            }
            finally
            {                
                rw.ReleaseWriterLock();
                readSem.Release();
            }
                       
        }

    public static string getOneCell()
        {       
        string encodedOrder=null;
         readSem.WaitOne();// wait until buffer cell is not empty then only read             
        ReaderWriterLock rw=new ReaderWriterLock();
        rw.AcquireWriterLock(Timeout.Infinite);
        try{        
        //reading from buffer --- ciruclar queue
            
            if (front_read == bufferSize - 1)
                 front_read = 0;
            else
                 {
            
                     front_read = front_read + 1;
                  }
           encodedOrder = buffer[front_read];
           buffer[front_read] = string.Empty;
           String[] arr=encodedOrder.Split('#');  
           Console.WriteLine("  chicken farm got an order from {0} of {1} chicken",arr[0],arr[2]);   
        }
        catch (Exception e){ Console.WriteLine(""); }
        finally
        {            
            rw.ReleaseWriterLock();
            writeSem.Release();
            
        }
        
        
            
        return encodedOrder;
        }
    }
}
