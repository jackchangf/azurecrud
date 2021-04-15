using System;

namespace cs_con_InheritanceConstructors
{
    class Program
    {
        static void Main()
        {
            MyChildClass objChild = new MyChildClass();

            Console.WriteLine();

            MyChildClass objChild2 = new MyChildClass(10);

            Console.WriteLine();
            Console.WriteLine("---- exiting the Main()!");
        }
    }
}
