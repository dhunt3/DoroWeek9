using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWWeek9Doro
{
    class IntString
    {
        static void Main(string[] args)
        {
            int num = 23;
            string result = IntStringConvert(num); // would not connect with the method under public string IntString
                                            // would only work with static string IntString... maybe cuz it's in
                                            // the same Program class.

            Console.WriteLine("Your integer {0} is now converted to string {1}", num, result);
            Console.ReadLine();
        }

        static string IntStringConvert(int num)
        {
            string numString = Convert.ToString(num);
            return numString;
        }

    }
}
