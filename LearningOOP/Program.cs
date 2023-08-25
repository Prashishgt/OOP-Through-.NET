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
            // implementing abstraction 
            Circle circle = new Circle(5.0);
            Reactangle rectangle = new Reactangle(4.0, 6.0);

            circle.Display();     
            rectangle.Display();

            // implementation of encapsulation
            Person p1 = new Person(1, "Harry", "Styles", "harry@gmail.com", "9813246717", "London");

            Console.WriteLine(p1.FirstName);
            Console.WriteLine(p1.LastName);
            Console.WriteLine(p1.Phone);
            string fName = "Prashish";
            p1.FirstName = fName;
            Console.WriteLine($"This change is after changing \"{p1.FirstName}\"");
            Console.ReadLine();
        }
    }
}
