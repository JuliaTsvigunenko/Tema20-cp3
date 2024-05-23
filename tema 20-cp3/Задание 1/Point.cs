using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point<T>
    {

        private T x;
        private T y;

        // Свойства доступа к внутренним полям класса
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point() { }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Поле x: {X}\nПоле y:{Y}");
        }



    }
}
