using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events
{
    public delegate void Del(int a, int b);
    public delegate void DelArgs(AddEventArgs e);
    public delegate void DelArgsObj(object s, AddEventArgs e);
  //  public delegate void EventHandler(Object s, EventArgs e);

    public class AddEventArgs : EventArgs
    {
        public int a;
        public int b;
        public AddEventArgs(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class Broadcast
    {
        public event Del Event;
        public event DelArgs EventArgs;
       // public event DelArgsObj EventArgsObj;
        public event EventHandler EventArgsObj1;
        //public event EventHandler<EventArgs> Event2;

        public void FireEvent(AddEventArgs ae)
        {
            Event(3, 5);
            EventArgs(ae);
            EventArgsObj1(this, ae);
            //Event2(this, null);
        }
    }
    class Subscriber
    {
        public void SubscribedEvent(int a, int b)
        {
            Console.WriteLine("Am in Subscribed Event " + (a + b));
        }
        public void SubscribedEvent1(int a, int b)
        {
            Console.WriteLine("Am in Subscribed 2 Event  " + (a + b));
        }
        public void SubscribedFrameworkMethod(object s, EventArgs e)
        {
            Console.WriteLine("Am in Framework Subscribed Event");
        }
        public void SubscribedEventArgs(AddEventArgs e)
        {
            Console.WriteLine("Am in Subscribed Event " + (e.a+e.b));
        }
        public void SubscribedEventArgsObj(object s,AddEventArgs e)
        {
            Console.WriteLine("Am in Subscribed Event " +s.ToString()+" "+ (e.a + e.b));
        }
        public void SubscribedEventArgsObjJust(object s, EventArgs e)
        {
            Console.WriteLine("Am in Subscribed Framework Event "  );
        }
    }
}
