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
        private int maxSpeed = 120;
        private bool carIsDead;

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
            this.speed = 10;

            Console.WriteLine("How many times would you like me to accelerate?");
            int numTimes = int.Parse(Console.ReadLine());
            for (int counter = 0; counter < numTimes; counter++ )
            {
                if (carIsDead)
                   Console.WriteLine("Uh-oh, car model " + model + " no longer works!");
                else 
                {
                    speed += 10;
                        if(speed > maxSpeed)
                        {
                            //Console.WriteLine("Your car model " + model + " has overheated!"); - Switched it out for Exception line below.
                            speed = 0;
                            carIsDead = true;
                            
                            //throw new Exception(string.Format("Your car model " + model + " has overheated!")); - original thrown exception.
                            
                            Exception help = new Exception(string.Format("Your car model " + model + " has overheated!"));
                            help.HelpLink = "http://www.CarRUs.com";
                            //throw help; - original throw option for just the help link.

                            help.Data.Add("Time Stamp", string.Format("Car exploded at " + DateTime.Now));
                            help.Data.Add("Cause", "You are heavy footed!");
                            throw help;
                            
                        }
                        else
                            Console.WriteLine("You are currently driving at " + speed + " miles per hour...");
                 }
               }
            }

        public void Decelerator()
        {
            if (carIsDead != true)
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
                            speed = speed - 10;
                            Console.WriteLine("You are now slowing down to " + speed + " miles per hour...");
                        }
                    }

                    Console.WriteLine("\n" + "You have stopped driving." + "\n");
                }
                else
                    Console.WriteLine("You are going too fast anyways, bye Felicia!");
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

