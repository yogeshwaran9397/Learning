using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Topics
{
    internal class TimerExample
    {
        System.Timers.Timer TriggerProcess;

        public TimerExample()
        {
            TriggerProcess = new System.Timers.Timer();
            TriggerProcess.Elapsed += TriggerProcess_Elapsed;
            TriggerProcess.Start();
            TriggerProcess.Interval = 1000;

        }

        private void TriggerProcess_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine($"Trigger {System.DateTime.Now.ToString()}");
        }
    }
}
