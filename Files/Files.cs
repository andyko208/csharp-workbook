using System;
using System.IO;
using System.Collections.Generic;
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            String file = @"/Users/andyko/Downloads/words_alpha.txt";
            // String copy = @"/Users/andyko/Desktop/copy.txt";
            // allStrings(file, copy);
            string[] wordsFile = File.ReadAllLines(file);
            Random rnd = new Random();
            int randIndex = rnd.Next(0, wordsFile.Length);
            Console.WriteLine(wordsFile[randIndex]);
            String ans = "";                            //user input string
            String randAns = wordsFile[randIndex];      //generate a random word from the array
            while(ans != randAns)
            {
                Console.WriteLine("Guess a word:");
                ans = Console.ReadLine();
                if(Array.IndexOf(wordsFile, ans) < Array.IndexOf(wordsFile, randAns))
                    Console.WriteLine("Your answer is before the actual one.");
                if(Array.IndexOf(wordsFile, ans) > Array.IndexOf(wordsFile, randAns))
                    Console.WriteLine("Your answer is after the actual one.");
            }
            Console.WriteLine("You got it!");
        }
        // public static void allStrings(String source, String dest){
        //     String[] words = File.ReadAllLines(source);
        //     File.WriteAllLines(dest, words);
        // }
    }
}
