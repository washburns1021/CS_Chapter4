using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubSales
{
    class Program
    {
        static void Main(string[] args)
        {
            String initial;
            double sales;
            double commission = 0.10;
            double totalSalesA = 0;
            double totalSalesB = 0;
            double totalSalesE = 0;

            Console.WriteLine("Enter Sales Persons First Intial: ");
            initial = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Sales amount: ");
            sales = Convert.ToDouble(Console.ReadLine());

            while (initial != "Z")
            {
                if (initial == "A")
                {
                    totalSalesA = totalSalesA + sales;
                }

                if (initial == "B")
                {
                    totalSalesB = totalSalesB + sales;
                }

                if (initial == "E")
                {
                    totalSalesE = totalSalesE + sales;
                }

                Console.WriteLine("Enter Sales Person's First Intial: ");
                initial = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter Sales amount: ");
                sales = Convert.ToDouble(Console.ReadLine());
            }

            if (initial == "Z")
            {
                Console.WriteLine("commissionmission for Andrea is: {0}", totalSalesA * commission);
                Console.WriteLine("commissionmission for Brittany is: {0}", totalSalesB * commission);
                Console.WriteLine("commissionmission for Eric is: {0}", totalSalesE * commission);
            }
        }
    }
}
