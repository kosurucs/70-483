using System;

namespace _70_483.EventsAndCallBacks
{
    public class EventsAndActions
    {
        public void CreateAndRaise()
        {
            var pub = new Pub();
            pub.OnChange += () => Console.WriteLine("First time got called 1.");
            pub.OnChange = () => Console.WriteLine("Second Time Got Called 2");
            pub.Raise();
        }

        public void CreateAndRaiseWithEvent()
        {
            var pub = new Pub();
            pub.OnChange += () => Console.WriteLine("First time got called 1.");
            pub.OnChange += () => Console.WriteLine("Second Time Got Called 2");
            pub.RaiseWithEvent();
        }

        public void CreateAndRaiseWithEventHandler()
        {
            var pub = new Pub();
            pub.OnChangeWithEventHandler += (sender, e) => Console.WriteLine("Event Raised :{0}", e.Value);
            pub.RaiseEventWhenEventHandler();
        }
    }

    public class Pub
    {
        public Action OnChange { get; set; }
        public event Action OnChanges = delegate { };
        public event EventHandler<MyArgs> OnChangeWithEventHandler = delegate { };

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }

        public void RaiseWithEvent()
        {
            OnChanges();
        }

        public void RaiseEventWhenEventHandler()
        {
            OnChangeWithEventHandler(this, new MyArgs(100));
        }
    }

    public class MyArgs : EventArgs
    {
        public int Value { get; set; }


        public MyArgs(int value)
        {
            Value = value;
        }
    }
}
