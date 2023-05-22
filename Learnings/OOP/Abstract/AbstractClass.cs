using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.OOP.Abstract
{
    public abstract class AbstractClass
    {
        int sampleInt = 0;
        public AbstractClass()
        {

        }

        public abstract void SampleAbstractMethod();

        public void SampleDemoMethod()
        {
            Console.WriteLine("Sample Demo Method");
        }

        public virtual void SampleVirtualMethod()
        {
            Console.WriteLine("Sample Virtual Method");
        }



    }
}
