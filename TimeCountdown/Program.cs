using System;

namespace TimeCountdown
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime days = DateTime.Today;
            TimeSpan p = DateTime.Now.Subtract(days);
            DateTime nextDayLearning = default;

            for (int i = 0; i < 7; i++)
            {
                if (days.DayOfWeek == DayOfWeek.Wednesday || days.DayOfWeek == DayOfWeek.Monday)
                {
                    nextDayLearning = days.AddHours(19);
                    break;
                }
                else
                {
                    days = days.AddDays(1);
                }
            }

            Console.SetWindowSize(35, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            var zero = new TimeSpan(0, 0, 0);
            //nextDayLearning = DateTime.Now.AddSeconds(5);
            while (p > zero)
            {
                Console.SetCursorPosition(0, 1);
                p = nextDayLearning.Subtract(DateTime.Now);

                string text = p.ToString();
                int ind = text.Length - 8;
                Console.WriteLine($"Времени до занятия: {text.Remove(ind)}  ");
                Console.SetCursorPosition(5, 2);

                /*text = p.TotalHours.ToString();
                ind = text.Length - 10;
                Console.WriteLine($"Часов до занятия: {text.Remove(ind)}");
                */
            }
        }
    }
}
/*//

TimeSpan ts = default;
                DateTime date1 = new DateTime(2021, 5, 3, 19, 00, 00); // 20.07.2015 18:30:25
                TimeSpan date2;
                date2 = date1.Subtract(DateTime.Now);
                Console.WriteLine($" {date2}"); // 03:00:00

Console.WriteLine("G: {0:G}", date2.ToString("G"));

                Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

                Console.SetCursorPosition(0, 0);
                //Console.WriteLine("D: " + now.ToString("D"));
                //"G: {0:G}", date2
                // Этот конструктор принимает год, месяц и день.
                DateTime dt = new DateTime(2015, 10, 17);
                // Какой это день месяца?
                Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
                //*/
