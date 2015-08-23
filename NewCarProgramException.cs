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
                Console.WriteLine("Method: " + e.TargetSite); //read only property from Exception class that describes details
                                                              //about the method that threw the exception.

                Console.WriteLine("Message " + e.Message);    //Read only property that returns the description of a given error

                Console.WriteLine("Source " + e.Source);      //This property gets or sets name of the library or object that
                                                              //threw the current exception.

                Console.WriteLine("Help link: " + e.HelpLink); //This property gets or sets a URL to a file or site describing the error
                Console.WriteLine("\n-> Custom Data:");

                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)  //read only property that retrieves a collection of key/value pairs that provide
                                                            //additional, programmer defined information about the exception. It is empty by default
                        Console.WriteLine("-> " + de.Key + ": " + de.Value);
                }
            }

            try
            {
                myCar.Stop();
            }

            catch (Exception e)
            {
                Console.WriteLine("Uh-oh, looks like your brakes are failing!");
                Console.WriteLine("***ERROR!***");
                Console.WriteLine("Method: " + e.TargetSite); //read only property from Exception class that describes details
                                                              //about the method that threw the exception.

                Console.WriteLine("Message " + e.Message);    //Read only property that returns the description of a given error

                Console.WriteLine("Source " + e.Source);      //This property gets or sets name of the library or object that
                                                              //threw the current exception.

            }
            
            Console.ReadLine();
        }
    }
}
