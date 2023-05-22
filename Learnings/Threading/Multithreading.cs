using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Learnings.Delegate.DelegateClass;

namespace Learnings.Threading
{
    public delegate void SampleDelegate(int a);
    public class ThreadingSample
    {
        public int num;
        public SampleDelegate _sampleDelegate;
        public ThreadingSample(int Num, SampleDelegate Sampledelegate)
        {
            num = Num;
            _sampleDelegate = Sampledelegate;
        }

        public void ExecuteSampleMethod()
        {
            if (_sampleDelegate != null)
            {
                _sampleDelegate.Invoke(num);
            }
        }
    }

    internal class Multithreading
    {

        #region Multihreading - wait 
        ManualResetEvent objAtu = new ManualResetEvent(false);
        public Multithreading()
        {

        }

        public void sampleMethod()
        {
            Console.WriteLine("start");
            objAtu.WaitOne();
            Console.WriteLine("mid");
            objAtu.WaitOne();
            Console.WriteLine("finish");
        }

        public void ThreadingCall()
        {
            Thread objThread = new Thread(sampleMethod);
            objThread.Start();
            Console.ReadLine();
            objAtu.Set();
        }

        #endregion

        #region Multithreading - callback 

        public void CallBackSample()
        {
            ThreadingSample objThreadSample = new ThreadingSample(10, sampleWriteMethod);
            objThreadSample.ExecuteSampleMethod();
        }

        public void sampleWriteMethod(int Result)
        {
            Console.WriteLine("Log" + Result);
        }

        #endregion
    }
}
