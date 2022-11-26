using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            foreach (var letter in words)
                Console.WriteLine(letter);
        }
    }
}
