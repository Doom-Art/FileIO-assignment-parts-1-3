using System.Runtime.CompilerServices;
using System.Text;

namespace FileIO_assignment_parts_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Part 1
            if (File.Exists(@"WordList.txt")){
                int count = 0;
                StreamWriter writer = new StreamWriter("CapitalWordList.txt");
                foreach (string i in File.ReadLines(@"WordList.txt", Encoding.UTF8))
                {
                    count++;
                    foreach (char c in i)
                    {
                        if (c == ' ')
                            count++;
                    }
                    writer.WriteLine(i.ToUpper());
                }
                Console.WriteLine($"The text file has {count} words");
                writer.Close();
                if (File.Exists(@"CapitalWordList.txt"))
                    Console.WriteLine("The file has succesfully been written.");
                else
                    Console.WriteLine("The file does not exist.");
            }
            Console.WriteLine();
            ///Part 2 
            if (File.Exists(@"PWordList.txt")){
                int palindromeNum = 0;
                int nonPalindromeNum = 0;
                StreamWriter palinWriter = new StreamWriter("PalindromeList.txt");
                StreamWriter nonPalinWriter = new StreamWriter("NonPalindromeList.txt");
                foreach(string i in File.ReadLines(@"PWordList.txt", Encoding.UTF8))
                {
                    if (i == Reverse(i)){
                        palindromeNum++;
                        palinWriter.WriteLine(i);
                    }
                    else
                    {
                        nonPalindromeNum++;
                        nonPalinWriter.WriteLine(i);
                    }
                }
                Console.WriteLine($"There are {palindromeNum} palindromes in the file.");
                Console.WriteLine($"There are {nonPalindromeNum} non palindromes in the file.");
            }
            Console.WriteLine();
            ///Part 3


        }
        public static string Reverse(string stringToReverse)
        {
            string reversedVersion = "";
            for (int i = (stringToReverse.Length) - 1; i >= 0; i--)
            {
                reversedVersion += stringToReverse[i];
            }
            return reversedVersion;
        }
    }
}