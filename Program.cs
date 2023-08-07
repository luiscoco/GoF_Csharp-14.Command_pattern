class Program
{
    static void Main(string[] args)
    {
        // Client code
        LightReceiver light = new LightReceiver();
        ICommand lightOnCommand = new LightOnCommand(light);
        ICommand lightOffCommand = new LightOffCommand(light);

        RemoteControl remoteControl = new RemoteControl();

        // Turning the light ON
        remoteControl.SetCommand(lightOnCommand);
        remoteControl.PressButton();

        // Turning the light OFF
        remoteControl.SetCommand(lightOffCommand);
        remoteControl.PressButton();
    }
}


// Command interface
public interface ICommand
{
    void Execute();
}

// ConcreteCommand 1
public class LightOnCommand : ICommand
{
    private LightReceiver _receiver;

    public LightOnCommand(LightReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.TurnOn();
    }
}

// ConcreteCommand 2
public class LightOffCommand : ICommand
{
    private LightReceiver _receiver;

    public LightOffCommand(LightReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.TurnOff();
    }
}


// Receiver
public class LightReceiver
{
    public void TurnOn()
    {
        Console.WriteLine("Light is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is OFF");
    }
}


// Invoker
public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}
