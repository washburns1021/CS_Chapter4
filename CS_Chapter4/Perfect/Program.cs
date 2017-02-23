using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                int runningTotal = 0;
                for(int j=1; j < i; j++)
                {
                    if (i % j == 0) runningTotal += j;
                }
                if (runningTotal == i) Console.WriteLine(i);
            }
        }
    }
}
