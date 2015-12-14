using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events
{
      class AddEventArgs : EventArgs
        {
            public int a;
            public int b;
            public AddEventArgs(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class ExtendedBroadcast
        {
            public event EventHandler<AddEventArgs> BroadcastEvent;
            public void OnFireEvent(AddEventArgs e)
            {
                BroadcastEvent(this, e);
            }
        }
        class ExtendedSubscriber
        {
            public void AddMethod(object s, AddEventArgs e)
            {
                Console.WriteLine("Am in Add Method" + (e.a + e.b));
            }
        }
    
}
