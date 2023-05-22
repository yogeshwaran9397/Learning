using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Inheritance
{

    public interface ISampleInterfaceA
    {
        public void MethodInterface1_A();
    }

    public interface ISampleInterfaceB
    {
        public void MethodInterface1_B();
    }

    public class SampleClassA
    {
        public void Method1()
        {
            Console.WriteLine("A - M1");
        }
    }

    public class SampleClassB : SampleClassA, ISampleInterfaceA, ISampleInterfaceB
    {
        public void Method1()
        {
            base.Method1();
            Console.WriteLine("B - M1");
        }

        public void Method2()
        {
            Console.WriteLine("B - M2");
        }

        public void MethodInterface1_A()
        {
            throw new NotImplementedException();
        }

        public void MethodInterface1_B()
        {
            throw new NotImplementedException();
        }
    }

    internal class Inheritance : SampleClassB
    {

    }
}
