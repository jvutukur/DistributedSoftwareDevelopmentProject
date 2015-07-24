using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TempConversionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, fahrenheit;                       
            //TempConversionService.WebService serviceObj = new TempConversionService.WebService();
            TemperatureConversionService.Service1Client serviceObj = new TemperatureConversionService.Service1Client();
            
            Console.WriteLine("Enter 1 to convert Celcius Temperature to Fahrenheit Temperatrue");
            Console.WriteLine("Enter 2 to convert Fahrenheit Temperatrue to Celcius Temperature");
            Console.WriteLine("Enter 3 to Exit");
            int selectedOption = int.Parse(Console.ReadLine());
            while(selectedOption!=3)
            {
                switch (selectedOption)
                {
                    case 1:
                        {
                            Console.WriteLine("\nEnter the temperature in Celsius");
                            celsius = int.Parse(Console.ReadLine());
                            fahrenheit = serviceObj.c2f(celsius);
                            Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nEnter the temperature in Fahrenheit");
                            fahrenheit = int.Parse(Console.ReadLine());
                            celsius = serviceObj.f2c(fahrenheit);
                            Console.WriteLine("Temperature in Celsius is: " + celsius);
                            break;
                        }
                    case 3:
                        {                          
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYou Entered value other than 1,2,3 Which are invalid. Please try again");
                            break;
                        }                        
                }
                Console.WriteLine("\nEnter 1 or 2 to use this app again");
                Console.WriteLine("Enter 3 to Exit");
                selectedOption = int.Parse(Console.ReadLine());
            }
                               
         
        }
    }
}
