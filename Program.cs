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
            //int[] array = new int[12];
            string ssid;
            //ask user for personal number
            Console.Write("Skriv in ett personnummer: ");
            
            ssid = Console.ReadLine();

            if (ssid.Length != 12)
            {
                Console.WriteLine("bajs");
                Console.ReadKey();
                return;
            }
            string year = ssid.Substring(0, 4);
            string month = ssid.Substring(4, 2);
            string day = ssid.Substring(6, 2);
            string birthNumber = ssid.Substring(8, 3);

            int yearCheck = Convert.ToInt32(year);
            if (yearCheck < 1753 || yearCheck > 2020)
            {
                Console.WriteLine("fel årtal");
                Console.ReadKey();
                return;
            }
            /*
            int monthCheck = Convert.ToInt32(month);
            if (monthCheck <= 0 || monthCheck >= 13)
            {
                Console.WriteLine("Fel månad");
                Console.ReadKey();
                return;
            }
            */
            int monthCheck = Convert.ToInt32(month);
            int dayCheck = Convert.ToInt32(day);
            if (monthCheck == 1)
            {
                if(dayCheck <= 0 || dayCheck >= 32)
                {
                    Console.WriteLine("januari fel datum");
                    Console.ReadKey();
                    return;
                }
            }
            else if(monthCheck == 2)
            {
                if(dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            /*
            int dayCheck = Convert.ToInt32(day);
            if (dayCheck <= 0 || dayCheck >= 32)
            {
                Console.WriteLine("fel dag");
                Console.ReadKey();
                return;
            }
            */
            int birthCheck = Convert.ToInt32(birthNumber);
            if (birthCheck < 0 || birthCheck > 999)
            {
                Console.Write("fel fyra sista");
                Console.ReadKey();
                return;
            }
            
            if(birthCheck % 2 == 0)
            {
                Console.WriteLine("Kvinna");
            }
            else
            {
                Console.WriteLine("Man");
            }
            


            Console.ReadKey();
            //year from 1753 - 2020
            //month 1 - 12
            //valid date to month 30 or 31
            //last numbers nnn should be from 000-999
            //control second to last number, even = male, uneven = female
            //print correct personal number and if user is male or female
        }
        static void monthCalc(int monthCheck, int dayCheck) //EN FÖR 30 DAGAR EN FÖR 31 DAGAR EN FÖR FEBRUARI, FIXA
        {
            if (monthCheck == 1)
            {
                if (dayCheck <= 0 || dayCheck >= 32)
                {
                    Console.WriteLine("januari fel datum");
                    Console.ReadKey();
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }
            else if (monthCheck == 2)
            {
                if (dayCheck <= 0 || dayCheck >= 28)
                {
                    return;
                }
            }

        }
    }
}
