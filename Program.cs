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
            string ssid;
            Console.Write("Skriv in ett personnummer: ");
            ssid = Console.ReadLine(); //reading the user input of the social security id

            if (ssid.Length != 12) //if the number provided isn't 12 characters long, return
            {
                Console.WriteLine("bajs");
                Console.ReadKey();
                return;
            }
            string year = ssid.Substring(0, 4);
            string month = ssid.Substring(4, 2);
            string day = ssid.Substring(6, 2);
            string birthNumber = ssid.Substring(8, 3); //creating substrings for the user inputted string, dividing it into year, month, day, and birthnumber

            int yearCheck = Convert.ToInt32(year);
            if (yearCheck < 1753 || yearCheck > 2020)//checking for valid year
            {
                Console.WriteLine("fel årtal");
                Console.ReadKey();
                return;
            }
            //LeapYear(yearCheck);
           
            int monthCheck = Convert.ToInt32(month); //converting month and day to int
            int dayCheck = Convert.ToInt32(day);
            MonthCalc(monthCheck, dayCheck, yearCheck); // calling on the month and day calculator method
          
            int birthCheck = Convert.ToInt32(birthNumber);
            if (birthCheck < 0 || birthCheck > 999) //checking the fourth to second to last ssid numbers 
            {
                Console.Write("fel fyra sista");
                Console.ReadKey();
                return;
            }
            
            if(birthCheck % 2 == 0) //checking the legal gender of the ssid, if the second to last number is even, it's female, uneven is male
            {
                Console.WriteLine("Kvinna");
            }
            else if(birthCheck % 2 != 0)
            {
                Console.WriteLine("Man");
            }
            Console.WriteLine("{0}", ssid);


            Console.ReadKey(); //stop
            //year from 1753 - 2020
            //month 1 - 12
            //valid date to month 30 or 31
            //last numbers nnn should be from 000-999
            //control second to last number, even = male, uneven = female
            //print correct personal number and if user is male or female
        }
        static void MonthCalc(int monthCheck, int dayCheck, int yearCheck)//checking if the day is valid to the month inputted by the user
        {//checking if the inputted ssid is a leap year, if it is, february has 29 days and not 28
            if (yearCheck % 400 == 0) //checking if the year divided by 400 is even, if it is even it's a leap year
            {
                if (monthCheck == 1 || monthCheck == 3 || monthCheck == 5 || monthCheck == 7 || monthCheck == 8 || monthCheck == 10 || monthCheck == 12)
                {
                    if (dayCheck <= 0 || dayCheck >= 32)
                    {
                        Console.WriteLine("januari fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 4 || monthCheck == 6 || monthCheck == 9 || monthCheck == 11)
                {
                    if (dayCheck <= 0 || dayCheck >= 31)
                    {
                        Console.WriteLine("30 fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 2)
                {
                    if (dayCheck <= 0 || dayCheck >= 30)
                    {
                        Console.WriteLine("feb fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            //if year divided by 100 is even it's not a leap year
            else if(yearCheck % 100 == 0)
            {
                if (monthCheck == 1 || monthCheck == 3 || monthCheck == 5 || monthCheck == 7 || monthCheck == 8 || monthCheck == 10 || monthCheck == 12)
                {
                    if (dayCheck <= 0 || dayCheck >= 32)
                    {
                        Console.WriteLine("januari fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 4 || monthCheck == 6 || monthCheck == 9 || monthCheck == 11)
                {
                    if (dayCheck <= 0 || dayCheck >= 31)
                    {
                        Console.WriteLine("30 fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 2)
                {
                    if (dayCheck <= 0 || dayCheck >= 29)
                    {
                        Console.WriteLine("feb fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            //if the year divided by 4 is even, it's a leap year
            else if(yearCheck % 4 == 0)
            {
                if (monthCheck == 1 || monthCheck == 3 || monthCheck == 5 || monthCheck == 7 || monthCheck == 8 || monthCheck == 10 || monthCheck == 12)
                {
                    if (dayCheck <= 0 || dayCheck >= 32)
                    {
                        Console.WriteLine("januari fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 4 || monthCheck == 6 || monthCheck == 9 || monthCheck == 11)
                {
                    if (dayCheck <= 0 || dayCheck >= 31)
                    {
                        Console.WriteLine("30 fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 2)
                {
                    if (dayCheck <= 0 || dayCheck >= 30)
                    {
                        Console.WriteLine("feb fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            else //if the year isn't dividable by 400, 100 or 4 it defaults to this and february having 28 days
            {
                if (monthCheck == 1 || monthCheck == 3 || monthCheck == 5 || monthCheck == 7 || monthCheck == 8 || monthCheck == 10 || monthCheck == 12)
                {
                    if (dayCheck <= 0 || dayCheck >= 32)
                    {
                        Console.WriteLine("januari fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 4 || monthCheck == 6 || monthCheck == 9 || monthCheck == 11)
                {
                    if (dayCheck <= 0 || dayCheck >= 31)
                    {
                        Console.WriteLine("30 fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (monthCheck == 2)
                {
                    if (dayCheck <= 0 || dayCheck >= 29)
                    {
                        Console.WriteLine("feb fel datum");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            
            
        }
        /*
        static void LeapYear(int year)
        {
            if(year % 400 == 0)
            {
                Console.WriteLine("skottår400");
                return;
            }
            else if(year % 100 == 0)
            {
                Console.WriteLine("inte skottår 100");
                return;
            }
            else if(year % 4 == 0)
            {
                Console.Write("skottår 4");
                return;
            }

        }*/
    }
}
