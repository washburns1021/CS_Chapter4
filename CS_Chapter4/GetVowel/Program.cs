using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Convert.ToString(Boolean.FalseString) != Convert.ToString(Boolean.TrueString))
            {
                Console.Write("Enter a vowel: ");
             
                Console.WriteLine("aeiou".Contains(Console.ReadLine().ToLower()) ? "that's a vowel" : "that's not a vowel");
            }
        }
    }
}
