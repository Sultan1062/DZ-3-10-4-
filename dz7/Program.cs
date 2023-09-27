using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int firstNumber = int.Parse(Console.ReadLine());
            int twoNumber = int.Parse(Console.ReadLine());
            int treeNumber = int.Parse(Console.ReadLine());
            int MaxValue; 
            if ((firstNumber < twoNumber) && (twoNumber < firstNumber))
            {
                MaxValue = firstNumber;
            }
            else
            {
                if (twoNumber < firstNumber)
                {
                    MaxValue = twoNumber;
                }
                else
                    MaxValue = treeNumber;
            }
            Console.WriteLine($"Минимальное значение = {MaxValue}");
            Console.ReadKey();


        }
    }
}
