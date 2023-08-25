using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LearningOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implementing abstraction
            Console.WriteLine("Implementing Abstraction");
            Circle circle = new Circle(5.0);
            Reactangle rectangle = new Reactangle(4.0, 6.0);

            circle.Display();
            rectangle.Display();
            Console.WriteLine("\n");
            // implementation of encapsulation
            Console.WriteLine("Implementing Encapsulation");
            Person p1 = new Person(1, "Harry", "Styles", "harry@gmail.com", "9813246717", "London");

            Console.WriteLine(p1.FirstName);
            Console.WriteLine(p1.LastName);
            Console.WriteLine(p1.Phone);
            string fName = "Prashish";
            p1.FirstName = fName;

            Console.WriteLine($"This change is after changing \"{p1.FirstName}\"");
            Console.WriteLine("\n");

            Console.WriteLine("Implementing Compile Time Polymorphism also know nas method overloading");
            // Implementation of Static / Complile time polymorphism
            Calculate c1 = new Calculate();
            Console.WriteLine("This is using int defined method " + c1.Add(5, 5));
            Console.WriteLine("This is using double defined method " + c1.Add(6, 6.5));
            Console.WriteLine("\n");

            // Implementation of Dynamic / Run time polymorphism
            Console.WriteLine("Implementing runt Time Polymorphism also know nas method overriding");
            GeneralShape gs = new GeneralShape();
            Triangle t1 = new Triangle();
            Octagon o1 = new Octagon();

            //calling the same method
             gs.Draw();
            //calling the same method from triagnle class
            t1.Draw();
            //calling the same method from octagon class
            o1.Draw();
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
