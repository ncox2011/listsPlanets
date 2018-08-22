using System;
using System.Collections.Generic;

namespace listsPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange( lastPlanets );
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            

            foreach (string item in planetList)
            {
                Console.WriteLine(item);
            }
            foreach (string item in rockyPlanets)
            {
                Console.WriteLine(item);
            }
        }
    }
}
