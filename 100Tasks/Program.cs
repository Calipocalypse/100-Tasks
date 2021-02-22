using System;

namespace _100Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeNowInHours = DateTime.Now.Hour;
            Console.WriteLine("Good " + GetWelcomeWord(timeNowInHours) + ". Which program you want to run right now?");
            _1_Name_Generator.Program.Run();
        }

        static string GetWelcomeWord(int hour)
        {
            if (hour >= 6 && hour < 12) return Day.Morning.ToString();
            else if (hour >= 12 && hour < 18) return Day.Afternoon.ToString();
            else return Day.Evening.ToString();
        }
    }

    enum Day
    {
        Morning, Afternoon, Evening
    }
}
