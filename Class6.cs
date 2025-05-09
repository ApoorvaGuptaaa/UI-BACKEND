// Subsystem classes
public class SubsystemA
{
    public void OperationA() => Console.WriteLine("SubsystemA OperationA");
}

public class SubsystemB
{
    public void OperationB() => Console.WriteLine("SubsystemB OperationB");
}

// Facade
public class Facade
{
    private SubsystemA _subsystemA = new SubsystemA();
    private SubsystemB _subsystemB = new SubsystemB();

    public void Operation()
    {
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }
}

// Usage
Facade facade = new Facade();
facade.Operation(); // Output: SubsystemA OperationA
                    //         SubsystemB OperationB
