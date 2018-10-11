using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // Console.WriteLine("Enter a word: ");
            // // leave this command at the end so your program does not close automatically
            // String inWord = Console.ReadLine();
            // Console.WriteLine("Your word became " + TranslateWord(inWord));
            if(tests()){
                Console.WriteLine("Tests passed.");
            } else {
                Console.WriteLine("Tests failed.");
            }
        }
        public static bool tests(){
            return 
                TranslateWord("elephant") == "elephantyay" &&
                TranslateWord("fox") == "oxfay" &&
                TranslateWord("choice") == "oicechay" && 
                TranslateWord("dye") == "yeday" && 
                TranslateWord("bystander") == "ystanderbay" &&
                TranslateWord("yellow") == "ellowyay" &&
                TranslateWord("tsktsk") == "tsktskyay"; //your code was "tsktskay" instead of "tsktskyay"
        }
        public static string TranslateWord(string word)
        {
            int firstLetterIndex = word.IndexOfAny(new char[] {'a', 'i', 'u', 'e', 'o'});
            int yChecker = word.IndexOfAny(new char[] {'y'});   //separate var checks if 'y' works as a vowel
            String part = "";   //the part that gets cut out
            if(firstLetterIndex == 0)   //#1 condition when first letter = vowel
            {
                part = word.Substring(0, firstLetterIndex);
                word = word.Substring(firstLetterIndex);
                word += part + "yay";
            }
            else if(yChecker >= 1 && firstLetterIndex > yChecker) //#2 condition when 'y' is used as a vowel
            {                                                     //only works when 'y' is before any other vowels
                part = word.Substring(0, yChecker);
                word = word.Substring(yChecker);
                word += part + "ay";
            }
            else if(firstLetterIndex >= 1)                //#3 condition when vowels, not 'y', exists but not 'y'
            {
                part = word.Substring(0, firstLetterIndex);
                word = word.Substring(firstLetterIndex);
                word += part + "ay";
            }
            else            //#4 condition when there are no vowels
            {
                word += "yay";
            }
            return word;
            
        }
    }
}
