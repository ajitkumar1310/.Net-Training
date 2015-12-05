using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void Del(int a, int b);
    class Broadcast
    {
        public event Del Event;
        public event EventHandler<EventArgs> Event2;
        public void FireEvent()
        {
            Event(3, 5);
            Event2(this, null);
        }
    }
    class Subscriber
    {
        public void SubscribedEvent(int a, int b)
        {
            Console.WriteLine("Am in Subscribed Event"+(a+b));
        }
        public void SubscribedFrameworkMethod(object s,EventArgs e)
        {
            Console.WriteLine("Am in Framework Subscribed Event" );
        }
    }
}
