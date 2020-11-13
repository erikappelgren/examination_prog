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
            if (ssid.Length != 12) //if the number provided isn't 12 characters long, stop here
            {
                Console.WriteLine("Felaktigt personnummer!");
                Console.ReadKey();
                return;
            }
            //creating substrings for the user inputted string, dividing it into year, month, day, and birthnumber
            string year = ssid.Substring(0, 4);
            string month = ssid.Substring(4, 2);
            string day = ssid.Substring(6, 2);
            string birthNumber = ssid.Substring(8, 3);

            int yearCheck = Convert.ToInt32(year);
            if (yearCheck < 1753 || yearCheck > 2020)//checking for valid year
            {
                Console.WriteLine("Felaktigt personnummer!");
                Console.ReadKey();
                return;
            }
            int monthCheck = Convert.ToInt32(month); //converting month and day to int
            int dayCheck = Convert.ToInt32(day);
            if (monthCheck < 0 || monthCheck >= 13)//checking for valid month
            {
                Console.WriteLine("Felaktigt personnummer!");
                Console.ReadKey();
                return;
            }
            if (MonthCalc(monthCheck, dayCheck, yearCheck))// calling on the month and day calculator method
            {
                int birthCheck = Convert.ToInt32(birthNumber);
                if (birthCheck < 0 || birthCheck > 999) //checking the fourth to second to last ssid numbers 
                {
                    Console.WriteLine("Felaktigt personnummer!");
                    return;
                }
                Console.WriteLine("{0} är ett korrekt personnummer!", ssid);
                if (birthCheck % 2 == 0) //checking the legal gender of the ssid, if the second to last number is even, it's female, uneven is male
                {
                    Console.WriteLine("Ditt kön är: Kvinna");
                }
                else if (birthCheck % 2 != 0)
                {
                    Console.WriteLine("Ditt kön är: Man");
                }
            }
            Console.ReadKey(); //stop
        }

        static bool MonthCalc(int monthCheck, int dayCheck, int yearCheck)//checking if the day is valid to the month inputted by the user
        {//checking if the inputted ssid is a leap year, if it is, february has 29 days and not 28
            bool leapYear = false;
            if (yearCheck % 400 == 0) //checking if the year is dividable by 400, if == 0 it's a leap year
            {
                leapYear = true;
            }
            else if (yearCheck % 100 == 0) //checking if the year is dividable by 100, if == 0 it's not a leap year
            {
                leapYear = false;
            }
            else if (yearCheck % 4 == 0) //checking if the year is dividable by 4, if == 0 it's a leap year
            {
                leapYear = true;
            }
            if (monthCheck == 1 || monthCheck == 3 || monthCheck == 5 || monthCheck == 7 || monthCheck == 8 || monthCheck == 10 || monthCheck == 12)
            {//checking all the months with 31 days, that the day input isn't bigger or smaller than the month
                bool dayOk = DayCheck(dayCheck, 32);
                return dayOk;
            }
            else if (monthCheck == 4 || monthCheck == 6 || monthCheck == 9 || monthCheck == 11)
            {//checking months with 30 days
                
                bool dayOk = DayCheck(dayCheck, 31);
                return dayOk;
            }
            else if (monthCheck == 2)
            {//if it's a leap year, february has 29 days, if not it's 28 days
                if (leapYear == true)
                {
                    bool dayOk = DayCheck(dayCheck, 30);
                    return dayOk;
                }
                else
                {
                    bool dayOk = DayCheck(dayCheck, 29);
                    return dayOk;
                }
            }
            return true;
        }

        static bool DayCheck(int dayCheck, int endDay)
        { //checking that the input day isn't bigger or smaller than the month
            if (dayCheck <= 0 || dayCheck >= endDay)
            {
                return false;
            }
            return true;
        }
    }
}
