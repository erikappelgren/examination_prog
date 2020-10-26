using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examination_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int personalNumber;
            //ask user for personal number
            Console.WriteLine("Skriv in ditt personnummer: ");
            personalNumber = Convert.ToInt32(Console.ReadLine());

            //12 numbers from 1753 - 2020
            //month 1 - 12
            //valid date to month 30 or 31
            //last numbers nnn should be from 000-999
            //control second to last number, even = male, uneven = female
            //print correct personal number and if user is male or female
        }
    }
}
