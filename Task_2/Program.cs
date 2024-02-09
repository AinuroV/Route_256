using System;
using System.Numerics;

namespace zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Extra_Day = 0;
            int[] day_month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // проверка на весокосный год
            bool leap_year(int year)
            {
                return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
            }
            // проверка на верность
            bool corected(int day, int month, int year)
            {
                // если год весокосный, то добавляем доп. день
                if (leap_year(year))
                {
                    Extra_Day = 1;
                }
                else
                {
                    Extra_Day = 0;
                }
                var max_days_in_month = day_month[month];
                // если февраль, то добавляем день в весокосном году
                if (month == 1)
                {
                    max_days_in_month += Extra_Day;
                }
                return day <= max_days_in_month;
            }
            var count = Convert.ToInt32(Console.ReadLine());
            var response = "";
            // Ввод данных
            for (int i = 0; i < count; i++)
            {
                var data = Console.ReadLine().Split();
                var day = int.Parse(data[0]);
                var month = int.Parse(data[1]) - 1;
                var year = int.Parse(data[2]);
                if (response.Length == 0)
                {
                    response += "";
                }
                else
                {
                    response += "\n";
                }
                if (corected(day, month, year))
                {
                    response += "Yes";
                }
                else
                {
                    response += "No";
                }
            }
            // Вывод данных
            Console.WriteLine(response);
        }
    }
}
