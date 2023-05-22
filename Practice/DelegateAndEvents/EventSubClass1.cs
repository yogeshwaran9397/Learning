using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DelegateAndEvents
{
    internal class EventSubClass1
    {
        public EventSubClass1()
        {

        }

        public void SubClassMethod1(object src, EventArgs args)
        {
            Console.WriteLine("Method 1");
        }
    }


    public class CustomEventClass
    {
        public CustomEventClass() { }

        public void CustomMethod1(object src, EventSubscriberData args)
        {
            Console.WriteLine($"Hello {args.Data}");
        }
    }
}
