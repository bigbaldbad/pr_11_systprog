using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_11_systprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Максимальное значение:  " + Max(array).ToString());
            Console.ReadLine();
        }
        static int Max(int[] array)
        {
            int max;
            return max = array.Max();
        }
    }
}
