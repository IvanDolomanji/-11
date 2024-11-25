using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Введите своё имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Привет, {name}!");
            //Console.WriteLine("До свидания!");

            //2
            //Console.WriteLine("Введите первое число:");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите второе число:");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Сумма: {a + b}");
            //Console.WriteLine($"Разность: {a - b}");
            //Console.WriteLine($"Произведение: {a * b}");
            //Console.WriteLine($"Частное: {(b != 0 ? (double)a / b : "Деление на ноль невозможно")}");

            //3
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            double y = x < 5 ? (4 * x * x + 1) / (x - 5) : 3 * x * x - 2;
            Console.WriteLine($"Значение функции y: {y}");
            Console.Read();
        }
    }
}
