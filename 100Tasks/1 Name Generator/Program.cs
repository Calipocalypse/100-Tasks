using System;
using System.Collections.Generic;
using System.Text;

namespace _100Tasks._1_Name_Generator
{
    public static class Program
    {
        public static void Run()
        {
            Console.Write("How many names you want to generate: ");
            int numberOfGenerations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfGenerations; i++)
            {
                string fullName = GenerateName();
                Console.WriteLine("Generated full name: " + fullName);
            }
        }

        private static string GenerateName()
        {
            string generatedFullName;
            // Randomize for first name
            Random randomized = new Random();
            int random = randomized.Next(0, Enum.GetNames(typeof(Name)).Length);
            generatedFullName = ((Name)random).ToString();

            // Randomize for last name
            random = randomized.Next(0, Enum.GetNames(typeof(LastName)).Length);
            generatedFullName += " " + ((LastName)random).ToString();

            return generatedFullName;
        }

        enum Name
        {
            Maciej, Rafał, Bartłomiej, Beniamin, Piotr, Dominik, Roman, Krystian, Albert, Witold, Mateusz, Wiktor, Paweł
        }

        enum LastName
        {
            Ziółkowski, Walipięta, Rozwadowski, Gwiazdowski, Lepiński, Wileński, Magdeburski, Wisłocki, Kupiec, Woźniak
        }
    }
}
