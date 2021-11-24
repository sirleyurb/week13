using System;
using System.Collections.Generic;
using System.IO;

namespace Ülesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirect = @"C:\Users\opilane\samples\week13";

            string[] dataFromFile = File.ReadAllLines($@"{rootDirect}\milkaway.txt");
            List<string> stars = new List<string>();
            List<string> planets = new List<string>();

            foreach (string element in dataFromFile)
            {
                if (element.Contains("stars"))
                {
                    stars.Add(element);
                }
                else if (element.Contains("planets"))
                {
                    planets.Add(element);
                }
            
            }
            File.WriteAllLines($@"{rootDirect}\stars.txt", stars);
            File.WriteAllLines($@"{rootDirect}\planets.txt2, planets);
        }
    }
}
