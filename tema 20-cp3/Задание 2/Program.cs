using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Целочисленный треугольник
            Triangle<int> triInt = new Triangle<int>(6, 2, 4);
            Console.WriteLine($"Целочисленный треугольник:");
            triInt.ShowInfo();
            Console.WriteLine($"Площадь: {triInt.Area()}");

            // Беззнаковый целочисленный треугольник
            Triangle<uint> triUint = new Triangle<uint>(17, 5, 3);
            Console.WriteLine($"\nБеззнаковый целочисленный треугольник:");
            triUint.ShowInfo();
            Console.WriteLine($"Площадь: {triUint.Area()}");

            // Вещественный треугольник
            Triangle<double> triDouble = new Triangle<double>(8.2, 1.2, 2.0);
            Console.WriteLine($"\nВещественный треугольник:");
            triDouble.ShowInfo();
            Console.WriteLine($"Площадь: {triDouble.Area()}");

            Console.ReadKey();

        }
    }
}
