using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    internal abstract class Shape
    {
        public abstract double CalculateArea();

        public void Display()
        {
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }

    class Circle: Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Reactangle: Shape
    {
        private double length, breadth;

        public Reactangle(double length, double breadth)
        {
            this.breadth = breadth;
            this.length = length;
        }

        public override double CalculateArea()
        {
            return length * breadth;
        }
    }


}
