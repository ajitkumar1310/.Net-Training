using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Broadcast b = new Broadcast();
            Subscriber s = new Subscriber();
            b.Event += s.SubscribedEvent;
            //b.Event += s.SubscribedEvent1;
            AddEventArgs ae = new AddEventArgs(10, 15);
            b.EventArgs += s.SubscribedEventArgs;
            b.EventArgsObj1 += s.SubscribedEventArgsObjJust;
            //b.Event2 += s.SubscribedFrameworkMethod;
           // b.Event2 += new EventHandler<EventArgs>(s.SubscribedFrameworkMethod);
            b.FireEvent(ae);
            //ExtendedBroadcast eb = new ExtendedBroadcast();
            //ExtendedSubscriber es = new ExtendedSubscriber();
            //eb.BroadcastEvent += new EventHandler<AddEventArgs>(es.AddMethod);
            //eb.OnFireEvent(new AddEventArgs(4, 5));
        }
    }
}
