using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arrDictionary = new Dictionary<string, int>();
            var input = "";
            int value = 0;
            do
            {
                input = Console.ReadLine();
                var arraySplit = input.Split(':');

                if (arraySplit.Length == 2 && Int32.TryParse(arraySplit[1], out value) &&
                  value >= 1 && value <= 5)
                {
                    arrDictionary[arraySplit[0]] = value;
                }
            } while (input != "stop");

            foreach (KeyValuePair<string, int> item in arrDictionary)
            {
                Console.WriteLine($"Student: {0}, Mark: {1}", item.Key, item.Value);
            }

            do
            {
                Console.WriteLine($"Pleas enter surname to see student's mark or a mark to see all students with it:");
                Console.WriteLine($"Or enter 'exit' to exit:");
                input = Console.ReadLine();
                foreach (KeyValuePair<string, int> item in arrDictionary)
                {
                    int output;
                    if (input == item.Key)
                    {
                        Console.WriteLine($"Student: {0}, received a {1}", item.Key, item.Value);   // Output student and her mark
                    }
                    else if (Int32.TryParse(input, out output) && output == item.Value)
                    {
                        Console.WriteLine($"Students with {item.Value} mark: ");
                        foreach (string key in arrDictionary.Keys)
                        {
                            Console.WriteLine(key);
                        }
                    }
                    else if (Int32.TryParse(input, out output) && output != item.Value)
                    {
                        Console.WriteLine($"There are no students with {item.Value} mark");
                    }
                    else
                    {
                        Console.WriteLine($"Input has wrong input :)");

                    }
                }
            } while (input != "exit");
        }
    }
}