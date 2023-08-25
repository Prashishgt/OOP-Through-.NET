using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    internal class GeneralShape
    {
        // also known as runtime polymorphism, it is acheived through the keyword "overriding". In there there will exist a 
        // base implementation and child classes can do their own implementation
        public virtual void Draw()
        {
            Console.WriteLine("Base Implementation to Draw");
        }
    }
    class Triangle : GeneralShape
    {
        public override void Draw()
        {
            Console.WriteLine("Now this will draw triangle");
        }
    }
    class Octagon : GeneralShape
    {
        public override void Draw()
        {
            Console.WriteLine("Now this will draw Octagon");
        }
    }
}
