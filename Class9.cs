// Subject
public class Subject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}

// Observer interface
public interface IObserver
{
    void Update();
}

// Concrete Observer
public class ConcreteObserver : IObserver
{
    private string _name;

    public ConcreteObserver(string name) => _name = name;

    public void Update() => Console.WriteLine($"{_name} has been notified.");
}

// Usage
Subject subject = new Subject();
IObserver observer1 = new ConcreteObserver("Observer 1");
IObserver observer2 = new ConcreteObserver("Observer 2");

subject.Attach(observer1);
subject.Attach(observer2);

subject.Notify();