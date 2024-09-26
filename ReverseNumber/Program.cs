using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            Console.WriteLine("Enter the Number: ");
            int number=Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                int temp = number % 10;
                value = value + temp;
                value = value * 10;


                number=number / 10;
            }
            value=value/10;
            Console.WriteLine("Reverse of the given number is: "+value);

        }
    }
}
