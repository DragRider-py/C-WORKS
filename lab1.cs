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

            for (int i = 0; i < stry.Length; i++)
            {
                for (int j = 0; j < strx.Length; j++)
                {
                    if (stry[i] == strx[j]) { Console.WriteLine(strx[j]); }
                }

            }
        }
    }
}
