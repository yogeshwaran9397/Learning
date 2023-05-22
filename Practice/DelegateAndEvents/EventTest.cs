using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DelegateAndEvents
{

    public class EventSubscriberData
    {
        public string Data = "";

        public EventSubscriberData(string data)
        {
            Data = data;
        }
    }

    //Publisher 
    internal class EventPublisher
    {

        //Delegate
        public delegate void DelegateTest(object sender, EventArgs e);
        public delegate void CustomDeleageTest(object sender, EventSubscriberData s);

        //Event 
        public event DelegateTest EventSample;
        public event CustomDeleageTest CustomEventSample;

        public EventPublisher()
        {

        }

        public void PublisherMethod(EventSubscriberData Data)
        {
            Console.WriteLine("Event Trigger");
            OnEventFire(Data);
        }

        protected virtual void OnEventFire(EventSubscriberData data)
        {
            if (EventSample != null)
            {
                EventSample(this, EventArgs.Empty);
            }

            if (CustomEventSample != null)
            {
                CustomEventSample(this, data);
            }
        }
    }
}
