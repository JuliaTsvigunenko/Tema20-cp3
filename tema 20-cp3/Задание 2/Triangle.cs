using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Triangle<T>
    {

        public T a { get; set; }
        public T b { get; set; }
        public T c { get; set; }

        // Конструктор с параметрами
        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Метод вывода информации о сторонах треугольника
        public void ShowInfo()
        {
            Console.WriteLine($"Сторона a = {a}\nСторона b = {b}\nСторона c = {c}");
        }

        // Метод вычисления площади треугольника
        public double Area()
        {
            double a1 = Convert.ToDouble(a);
            double b1 = Convert.ToDouble(b);
            double c1 = Convert.ToDouble(c);

            double perimeter = a1 + b1 + c1;
            double semiPerimeter = perimeter / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - a1) * (semiPerimeter - b1) * (semiPerimeter - c1));
        }




    }
}
