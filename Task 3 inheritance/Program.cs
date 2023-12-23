using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 5, 5, "Равносторонний");
            triangle.Print();
            Console.WriteLine("Площадь: " + Math.Round(triangle.Area(), 2));
            
            TriangleColor triangle2 = new TriangleColor(3, 4, 5, "Прямоугольный", Color.Red);
            Console.WriteLine();
            triangle2.Print();
            Console.WriteLine("Площадь: " + Math.Round(triangle2.Area(), 2));
            Console.ReadKey();
        }
    }
}
