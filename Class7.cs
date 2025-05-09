// Handler interface
public abstract class Handler
{
    protected Handler successor;

    public void SetSuccessor(Handler successor) => this.successor = successor;

    public abstract void HandleRequest(int request);
}

// Concrete Handlers
public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 10)
        {
            Console.WriteLine($"ConcreteHandler1 handled request {request}");
        }
        else
        {
            successor?.HandleRequest(request);
        }
    }
}

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10)
        {
            Console.WriteLine($"ConcreteHandler2 handled request {request}");
        }
        else
        {
            successor?.HandleRequest(request);
        }
    }
}

// Usage
Handler handler1 = new ConcreteHandler1();
Handler handler2 = new ConcreteHandler2();
handler1.SetSuccessor(handler2);

int[] requests = { 5, 14, 22, 3 };
foreach (int request in requests)
{
    handler1.HandleRequest(request);
}
