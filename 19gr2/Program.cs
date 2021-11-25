using System;
using System.Collections.Generic;

namespace _19gr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();

            //names.Add("Ramunas");
            //names.Add("Vaidas");
            //names.Add("Tautvydas");
            //names.Add("Vilma");


            //List<string> first = new List<string> { "One", "Two", "Three" };
            //List<string> second = new List<string>() { "Four", "Five" };

            //names.AddRange(first);

            //foreach (string vardas in names)
            //{
            //    Console.WriteLine(vardas);
            //}
            //Console.WriteLine(names.Count);
            //names.Remove("Vaidas");
            //names.RemoveAt(3);
            //names.ForEach(vardas => { Console.WriteLine(vardas); });

            Random rnd = new Random();
            List<int> nums = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                nums.Add(rnd.Next(5, 26));
            }
            nums.ForEach(nr => { Console.WriteLine(nr); });

        }
    }
}
