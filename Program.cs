using System.Runtime.CompilerServices;
using System.Text;

namespace FileIO_assignment_parts_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"WordList.txt")){
                foreach (string i in File.ReadLines(@"WordList.txt", Encoding.UTF8))
                {
                    Console.WriteLine(i);
                }
                int count = 0;
                foreach (string i in File.ReadLines(@"WordList.txt", Encoding.UTF8))
                {
                    count++;
                    foreach (char c in i)
                    {
                        if (c == ' ')
                            count++;
                    }
                }
                Console.WriteLine($"The text file has {count} words");
            }
        }
    }
}