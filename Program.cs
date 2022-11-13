using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            Console.WriteLine("Ввод Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            //Ввод основного числа Х
            Console.WriteLine("Ввод массива через пробел: ");
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //Ввод массива чисел
            int l1 = array.Length;
            double[] mass = new double[l1];

            for (int j = 0; j < l1; j++) mass[j] = array[j];
            Array.Sort(mass);
            Console.WriteLine("Чётные числа после сортировки: ");
            for (int j = 0; j < l1; j++) if ((int)mass[j] % 2.0 == 0) Console.Write(mass[j] + " ");
            Console.WriteLine();

            Console.WriteLine("Нечётные числа меньше Х");
            for (int j = 0; j < array.Length; j++) if (array[j] < x && (int)array[j] % 2.0 != 0) Console.Write(array[j] + " ");
        }
    }
}
