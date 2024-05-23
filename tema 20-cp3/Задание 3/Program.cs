using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Целочисленный отрезок
            Segment<int> segmentInt = new Segment<int>(2, 0, 5, 0);
            Console.WriteLine("Целочисленный отрезок:");
            segmentInt.ShowInfo();
            Console.WriteLine($"Длина: {segmentInt.Length()}");

            // Отрезок с длинными числами
            Segment<long> segmentLong = new Segment<long>(2, 5, 1, 6);
            Console.WriteLine("\nОтрезок с длинными числами:");
            segmentLong.ShowInfo();
            Console.WriteLine($"Длина: {segmentLong.Length()}");

            // Вещественный отрезок
            Segment<double> segmentDouble = new Segment<double>(0.1, 1.6, 4.2, 8.1);
            Console.WriteLine("\nВещественный отрезок:");
            segmentDouble.ShowInfo();
            Console.WriteLine($"Длина: {segmentDouble.Length()}");

            Console.ReadKey();

        }
    }
}
