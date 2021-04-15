using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InheritanceConstructors
{
    class MyParentClass
    {
        /// <summary>
        ///     Default Constructor
        /// </summary>
        public MyParentClass()
        {
            Console.WriteLine("--- parent Default Constructor called!");
        }

        /// <summary>
        ///     Parameterized Constructor
        /// </summary>
        /// <param name="id">ID as an argument</param>
        public MyParentClass(int id)
        {
            Console.WriteLine($"--- parent Parameterized Constructor called with {id}!");
        }

        ~MyParentClass()
        {
            Console.WriteLine("parent destructor called!");
        }
    }
}
