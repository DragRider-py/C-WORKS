using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 a = 95358420661899;
            Int64 c = a;
            Int64 b = 10;
            Int64 max = 0,min = 0;
            while (a > 0)
            {
              if (max < a % 10) max = a % b;
                 a /= 10;
             }
            while (a > 0)
            {
                if (min > a % 10) min = a % b;
                a /= 10;
            }
            Console.Write(max+""+min);
            string s = c.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new String(ar);
            c = Convert.ToInt64(s);
            Console.WriteLine(c);
        }
    }
}
