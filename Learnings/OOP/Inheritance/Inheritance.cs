using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.OOP.Inheritance
{
    public class Class1
    {
        public string Id { get; set; }
        public Class1()
        {
            Id = "Class1";
        }
    }

    public class Class2 : Class1
    {
        public string Id { get; set; }
        public Class2() // consider is we make this as private Inheritance class will throw error 
        {
            Id = "Class2";
        }
    }

    internal class Inheritance : Class2
    {
       Inheritance()
        {

        }
    }
}
