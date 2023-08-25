using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            Reactangle rectangle = new Reactangle(4.0, 6.0);

            circle.Display();     
            rectangle.Display();
            Console.ReadLine();
        }
    }
}
