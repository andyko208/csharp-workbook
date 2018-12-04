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
            String copy = @"/Users/andyko/Desktop/copy.txt";
            allStrings(file, copy);
            string[] wordsFile = File.ReadAllLines(file);
        }
        public static void allStrings(String source, String dest){
            String[] words = File.ReadAllLines(source);
            File.WriteAllLines(dest, words);
        }
    }
}
