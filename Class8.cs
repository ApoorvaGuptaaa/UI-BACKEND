// Command interface
public interface ICommand
{
    void Execute();
}

// Concrete Command
public class LightOnCommand : ICommand
{
    private Light _light;

    public LightOnCommand(Light light) => _light = light;

    public void Execute() => _light.On();
}

// Receiver
public class Light
{
    public void On() => Console.WriteLine("Light is On");
    public void Off() => Console.WriteLine("Light is Off");
}

// Invoker
public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command) => _command = command;

    public void PressButton() => _command.Execute();
}

// Usage
Light light = new Light();
ICommand lightOn = new LightOnCommand(light);
RemoteControl remote = new RemoteControl();
remote.SetCommand(lightOn);
remote.PressButton(); // Output: Light is On
