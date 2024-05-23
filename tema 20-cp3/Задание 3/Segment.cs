using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Segment<T>
    {
        public T X1 { get; set; }
        public T Y1 { get; set; }
        public T X2 { get; set; }
        public T Y2 { get; set; }

        // Конструктор с параметрами
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        // Метод вывода информации об отрезке
        public void ShowInfo()
        {
            Console.WriteLine($"Отрезок с координатами ({X1}, {Y1}) и ({X2}, {Y2})");
        }

        // Метод, возвращающий длину отрезка
        public double Length()
        {
            dynamic x1 = Convert.ToDouble(X2) - Convert.ToDouble(X1);
            dynamic y1 = Convert.ToDouble(Y2) - Convert.ToDouble(Y1);

            return Math.Sqrt(x1 * x1 + y1 * y1);
        }



    }
}
