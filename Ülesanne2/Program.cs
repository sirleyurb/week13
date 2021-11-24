using System;
using System.IO;

namespace Ülesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\week13";
            string file1 = "stars";
            string file2 = "planets";
            Console.WriteLine("enter file name:");
            string fileName = Console.ReadLine();
            string fullfile1Path = $@"{rootDirectory}\{file1}.txt";
            string fullfile2Path = $@"{rootDirectory}\{file2}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool file1Exists = File.Exists(fullfile1Path);
            bool file2Exists = File.Exists(fullfile2Path);
            

            if (directoryExists && file1Exists && file2Exists)
            {
                Console.WriteLine($"{file1} and {file2} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullfile1Path);
                File.Create(fullfile2Path);
                Console.WriteLine($"{file1}.txt and {file2}.txt have been created in {rootDirectory}.");
            }
            else
            {
                File.Create(fullfile1Path);
                File.Create(fullfile2Path);
                Console.WriteLine($"{file1}.txt and {file2}.txt has been created in {rootDirectory}.");
            }

        }
    }
}
