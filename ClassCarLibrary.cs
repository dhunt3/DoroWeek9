using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTestLibDoro
{
    public class Car
    {
        private string make;
        private string model;
        private int speed;
        private int speedAdder;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int SpeedAdder
        {
            get { return this.speedAdder; }
            set { this.speedAdder = 25;  }
        }
            
        public Car()
        {
            this.make = "Nissan";
            this.model = "Altima";
        }
            
        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            
        }

        public void Accelerator()
        {
            this.speed = 25;

            Console.WriteLine("How many times would you like me to accelerate?");
            int numTimes = int.Parse(Console.ReadLine());
            for (int counter = 0; counter < numTimes; counter++ )
            {
                speed += 25;
                Console.WriteLine("You are currently driving at " + speed + " miles per hour...");
            }
                
            
        }

        public void Decelerator()
        {
            Console.WriteLine("\n" + "Would you like to slow down? yes or no?");
            string userReply = Console.ReadLine();

            if (userReply == "yes")
            {
                while (this.speed != 0)
                {
                    if (this.speed == 0)
                        Console.WriteLine("You have stopped driving.");
                    else
                    {
                        speed = speed - 25;
                        Console.WriteLine("You are now slowing down to " + speed + " miles per hour...");
                    }
                }

                Console.WriteLine("\n" + "You have stopped driving." + "\n");
            }
        }

        public void Drive()
        {
            int newSpeed = this.speed + 25;
            Console.WriteLine("You are currently driving at " + newSpeed + " miles per hour..." + "\n");
        }

        public void Stop()
        {
            Decelerator();             
        }
    }
}

