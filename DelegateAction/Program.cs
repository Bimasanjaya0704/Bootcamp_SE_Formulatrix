﻿public class Subscriber
{
    public void GetNotification()
    {
        Console.WriteLine("Thanks for your subscribe!!");
    }
}

public class Publisher
{
    private Action _subscriber;
    private List<Action> _history = new();

    private bool CheckDelegate(Action myDel)
    {
        if (_subscriber is not null)
        {
            Delegate[] delegates = _subscriber.GetInvocationList();
            if (delegates.Contains(myDel))
            {
                return true;
            }
        }
        return false;
    }

    public bool AddSubs(Action myDel)
    {
        if (!CheckDelegate(myDel))
        {
            _subscriber += myDel;
            _history.Add(myDel);
            return true;
        }
        return false;
    }
    public bool RemoveSubs(Action myDel)
    {
        if (CheckDelegate(myDel))
        {
            _subscriber -= myDel;
            return true;
        }
        return false;
    }
    public void NotifySubscribers()
    {
        _subscriber?.Invoke();
    }

    public List<Action> CheckAllSub()
    {
        return _history;
    }

    public bool CheckSub(Action sub)
    {
        if (_history.Contains(sub))
        {
            return true;
        }
        return false;
    }
}

public class Program
{
    static void Main()
    {
        Publisher pub = new();
        Subscriber subs1 = new();
        Subscriber subs2 = new();
        Subscriber subs3 = new();
        Subscriber subs4 = new();

        pub.AddSubs(subs1.GetNotification);
        pub.AddSubs(subs2.GetNotification);
        pub.AddSubs(subs3.GetNotification);
        pub.AddSubs(subs4.GetNotification);
        pub.AddSubs(subs1.GetNotification);
        pub.NotifySubscribers();
    }
}


