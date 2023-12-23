using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_inheritance
{
    public abstract class Figure
    {
        private string name;

        public Figure(string Name)
        {
            name = Name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected abstract double Area2 { get; }
        public abstract double Area();
        public virtual void Print()
        {
            Console.WriteLine("Название: {0}", name);
        }
    }

    public class Triangle : Figure
    {
        double a;
        double b;
        double c;

        public Triangle(double A, double B, double C, string Name) : base(Name)
        {
            a = A;
            b = B;
            c = C;
        }

        public void GetABC(out double A, out double B, out double C)
        {
            A = a;
            B = b;
            C = c;
        }

        public void SetABC(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        protected override double Area2
        {
            get
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override double Area()
        {
            return Area2;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Стороны: a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }

    public class TriangleColor : Triangle
    {
        Color backgroundColor;

        public TriangleColor(double A, double B, double C, string Name, Color BackgroundColor) : base(A, B, C, Name)
        {
            backgroundColor = BackgroundColor;
        }

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        protected override double Area2 => base.Area2;

        public override double Area()
        {
            return Area2;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Цвет фона треуголника: {0}", backgroundColor.Name);
        }
    }
}
