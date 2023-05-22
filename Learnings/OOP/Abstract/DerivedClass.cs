using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.OOP.Abstract
{

    internal class DerivedClass : AbstractClass
    {
       public DerivedClass()
        {

        }

        public void SampleDemoMethod()
        {
            Console.WriteLine("Sample Demo Method in Derived");
        }

        public override void SampleAbstractMethod()
        {
            Console.WriteLine("Implementation Method");
        }

        public override void SampleVirtualMethod()
        {
            base.SampleVirtualMethod();
            Console.WriteLine("Virtual in derived");
        }
    }
}
