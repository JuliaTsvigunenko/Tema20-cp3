using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Point<int> point = new Point<int>(4, 2);
            point.ShowInfo();
            Point<double> point1 = new Point<double>(6.2, 1.2);
            point1.ShowInfo();
            Point<uint> point2 = new Point<uint>(3, 2);
            point.ShowInfo();


            Console.ReadKey();


        }
    }
}
