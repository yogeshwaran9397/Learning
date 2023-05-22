using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Topics
{
    public class Generics<T>
    {
        public T value;

        public Generics(T Value)
        {
            value = Value;
        }

        public void GetType()
        {
            Console.WriteLine($"Type is {typeof(T)} ! Value is {value}");
        }

    }
}
