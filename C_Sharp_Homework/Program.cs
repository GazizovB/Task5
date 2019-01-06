using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Number(number);

            Console.ReadLine();
        }

        public static int Number(int number)
        {
            Console.Write("Результат: ");
            while (number > 0)
            {
                int number1 = number % 10;
                Console.Write(number1);
                number /= 10;
            }
            return number;
        }
    }
}
