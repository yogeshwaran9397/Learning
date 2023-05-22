using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DelegateAndEvents
{
    internal class DelegateExample
    {
        public delegate void SampleDelegate();

        public SampleDelegate Del;

        public DelegateExample()
        {
            Del = new SampleDelegate(SampleMethod1);
            Del += SampleMethod2;
            Del.Invoke();
        }

        public void SampleMethod1()
        {
            Console.WriteLine("Method 1");
        }
        public void SampleMethod2()
        {
            Console.WriteLine("Method 2");
        }

    }
}
