using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter digits now");
            List<int> numbers = new List<int>();
            int desiredNumber = 999;
            int number = 0;
            do
            {
                string str = Console.ReadLine();
                int.TryParse(str, out number);
                numbers.Add(number);
            } while (!numbers.Contains(desiredNumber));

            Console.WriteLine("Sum of numbers {0}", numbers.Except(new List<int> { desiredNumber }).Sum());
            Console.ReadLine();

        }
    }
}

