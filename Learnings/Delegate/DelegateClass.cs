using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Delegate
{
    internal class DelegateClass
    {
        //Declare a Delegate
        public delegate int SampleDelegate(int a, int b);

        public void MethodWithDelegateParam(SampleDelegate paramDelegate)
        {
            paramDelegate(1, 2);
        }

        public void DelegateMethod()
        {
            SampleDelegate delegate_Sample = new SampleDelegate(Sum);
            MethodWithDelegateParam(delegate_Sample);

            delegate_Sample(1, 2);

            //multicast Delegate 
            delegate_Sample += Minus;
            delegate_Sample(2, 3);
        }

        public static int Sum(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;

        }

        public static int Minus(int a, int b)
        {
            Console.WriteLine(a - b);
            return a + b;
        }
    }
}
