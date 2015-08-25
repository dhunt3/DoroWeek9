using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootDoro
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            
            try
            {
                SqrtFun();
            }

            catch (Exception e)
            {
                Console.WriteLine("\n" + "**Error**");
                Console.WriteLine("Method: " + e.TargetSite);
                Console.WriteLine("Message: " + e.Message);
            }

            finally
            {
                Console.WriteLine("\n" + "Goodbye");
            }

            Console.ReadLine();
       }

        public static void SqrtFun()
        {
            int num;
            Console.WriteLine("Please enter a positive number: ");
            bool result = int.TryParse(Console.ReadLine(), out num);

            if (result == true && num >= 0)
            {
                double answer = Math.Sqrt(num);
                Console.WriteLine("\n" + "The square root of {0} is {1}", num, answer);
            }
            
            else
                throw new Exception(string.Format("Your number is invalid!"));
        }
    }
}
