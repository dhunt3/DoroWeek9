using System;
using CarTestLibDoro;
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
            
            myCar.Accelerator();
            

            myCar.Stop();
            
            Console.ReadLine();
        }
    }
}
