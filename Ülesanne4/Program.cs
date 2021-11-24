using System;
using System.IO;

namespace Ülesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\opilane\samples\week13";
            Console.WriteLine("millist faili soovite näha? 'stars', 'planets'");
            string userFile = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\ {userFile}.txt";
            bool exists = File.Exists(fileDirect);

            if(exists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (userFile == "stars" || userFile == "planets")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }

                else
                {
                    Console.WriteLine($"{userFile}.txt ei eksisteeri");
                }
            }
        }
    }
}
