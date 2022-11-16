using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            string strx = x.ToString();
            string stry = y.ToString();

            int count = 0;
            for (int i = 0; i < strx.Length; i++)
            { for(int j=0; j < stry.Length; j++) {
                    if (strx[i] == stry[j]) Console.WriteLine(strx[i]); count++;
                    Console.WriteLine(" "+count);
                }

            }
        }
    }
}
