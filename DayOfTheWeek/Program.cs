using System;

namespace DayOfTheWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a day");
            int day = int.Parse(Console.ReadLine());
            int dayofweek = DayOfTheWeek(year, month, day);
            Console.WriteLine("The day of the week is:");
            switch (dayofweek)
            {
                case 0: Console.WriteLine("Sunday"); break;
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Unknown"); break;
            }
        }
        public static int DayOfTheWeek(int year, int month, int day)
        {
         
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (month < 3)
            {
                year--;
            }
            int y = year % 100;
            int c = year / 100;
            int w = (int)((c / 4) - (2 * c) + y + (y / 4) + t[month - 1] + day) % 7;
         
            return w;
        }

    }
}
