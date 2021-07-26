using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(new A() as I1).M();");
            (new A() as I1).M();
            Console.WriteLine("(new A() as I2).M();");
            (new A() as I2).M();
            Console.WriteLine("(new B() as I1).M();");
            (new B() as I1).M();
            Console.WriteLine("(new B() as I2).M();");
            (new B() as I2).M();
            Console.WriteLine("(new B() as A as I1).M();");
            (new B() as A as I1).M();
            Console.WriteLine("(new B() as A as I2).M();");
            (new B() as A as I2).M();
        }
    }
}
