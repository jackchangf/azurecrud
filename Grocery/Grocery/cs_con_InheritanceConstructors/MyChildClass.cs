using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InheritanceConstructors
{
    class MyChildClass
        : MyParentClass
    {
        /// <summary>
        ///     Default Constructor
        /// </summary>
        public MyChildClass()
        {
            Console.WriteLine("--- child Default Constructor called!");
        }

        /// <summary>
        ///     Parameterized Constructor
        /// </summary>
        /// <param name="id">ID as an argument</param>
        public MyChildClass(int id)
            : base(id)
        {
            Console.WriteLine($"--- child Parameterized Constructor called with {id}!");
        }

        ~MyChildClass()
        {
            Console.WriteLine("--- child Destructor called!");
        }
    }
}
