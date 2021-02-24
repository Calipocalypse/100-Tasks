using System;
using System.Collections.Generic;
using System.Text;

namespace _100Tasks._2_Heads_Or_Tails
{
    public static class Program
    {
        public static void Run()
        {
            Console.Write("Heads or tails. Type h/t:  ");
            try
            {
                string ht = Console.ReadLine();
                if (ht != "h" && ht != "t") throw new Exception();
                Side side = GetRandomSideOfCoin();
                if (HasWon(ht, side)) Console.WriteLine("Congratulations, you've won! ");
                else Console.WriteLine("Shame but you've lost... ");
                Console.WriteLine("The side was: " + side.ToString());
                Console.WriteLine("");
                Run();

            }
            catch
            {
                Console.WriteLine("Something gone wrong. Please type ( h ) or ( t ). /n");
                Run();
                return;
            }
        }

        private static bool HasWon(string ht, Side side)
        {
            if (ht.ToLower() == ((side.ToString()).Substring(0, 1)).ToLower()) return true;
            else return false;
        }

        private static Side GetRandomSideOfCoin()
        {
            Random rand = new Random();
            int random = rand.Next(0, 2);
            if (random == 0) return Side.Head;
            else return Side.Tail;
        }

        enum Side
        {
            Head, Tail
        }
    }
}
