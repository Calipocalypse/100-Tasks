using System;
using System.Collections.Generic;
using System.Text;

namespace _100Tasks._3_Temperature_Converter
{
    public static class Program
    {
        static List<string> acceptableTypes = new List<string> { "C", "F", "K" };

        public static void Run()
        {
            /* 1. Get the type of scale and value */
            string type = GetTypeOfTemperature();
            if (!IsValidType(type, acceptableTypes))
            {
                Run();
                return;
            }
            double? temperature = GetValueOfTemperature(type);


            Console.WriteLine("Please specify amount of *" + type);


            
            /* 2. Convert to *C if not *C */
            /* 3. Convert from *C to anything else */
            /* 4. Display */
            }

        #region Program

        private static string GetTypeOfTemperature()
        {
            Console.Write("Please specify the scale of temperature. Acceptable scales: ");
            string type = Console.ReadLine();
            return type;
        }

        private static double GetValueOfTemperature(string type)
        {
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Something gone wrong, please re-write amount of *" + type);
            }
        }

        #endregion

        private static bool IsValidType(string type, List<string> acceptableTypes)
        {
            foreach (var typeFromList in acceptableTypes)
            {
                if (typeFromList == type.ToUpper()) return true;
            }
            return false;
        }

        private static void WriteAllTypes(List<string> acceptableTypes)
        {
            foreach (var type in acceptableTypes)
            {
                Console.Write(type + ", ");
            }
        }
    }
}
