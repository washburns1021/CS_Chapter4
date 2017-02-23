using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int num, sum = 0;
                for (num = 1; num <= 50; num++)
                {
                    sum = sum + num;
                }
                Console.WriteLine("Sum = {0}", sum);
                Console.ReadLine();
            }
        }
    }
}
