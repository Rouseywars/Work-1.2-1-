using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус:");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Высота:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Объем цилиндра: {0}  Объем конуса: {1}", Math.PI * r * r * h, 1 / 3 * Math.PI * r * r * h);
            Console.ReadKey();
        }
    }
}
