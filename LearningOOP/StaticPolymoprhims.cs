using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    internal class Calculate
    {
        // also known as compile time polymorphism, it involves similar methods but with different arguments
        // when in complie time it chooses the most appropriate one with provided arguments below is an example of it
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

}
