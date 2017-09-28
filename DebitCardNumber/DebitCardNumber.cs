using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine()); //Reads first digits
            int second = int.Parse(Console.ReadLine()); //Reads second digits
            int third = int.Parse(Console.ReadLine()); //Reads third digits
            int forth = int.Parse(Console.ReadLine()); //Reads forth digits

            Console.WriteLine($"{first:D4} {second:D4} {third:D4} {forth:D4}");
        }
    }
}
