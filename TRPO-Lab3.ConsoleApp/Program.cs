using System;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Введите радиус цилиндра");
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            double h;
            Console.WriteLine("Введите высоту цилиндра");
            while (!double.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Ошибка ввода!");
            }

            Console.WriteLine("Площадь поверхности цилиндра\n" + new Cylinder().SurfArea(r, h));
        }
    }
}