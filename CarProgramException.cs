using System;
using CarTestLibDoro;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgramDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car yourCar = new Car("Toyota", "Camry");

      
            myCar.Drive();

            try
            {
                myCar.Accelerator();
            }

            catch (Exception e)
            {
                Console.WriteLine("***ERROR!***");
                Console.WriteLine("Method: " + e.TargetSite); 
                Console.WriteLine("Message " + e.Message);
                Console.WriteLine("Source " + e.Source);
                Console.WriteLine("Help link: " + e.HelpLink);
                Console.WriteLine("\n-> Custom Data:");

                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("-> " + de.Key + ": " + de.Value);
                }
            }
            
            myCar.Stop();
            
            Console.ReadLine();
        }
    }
}
