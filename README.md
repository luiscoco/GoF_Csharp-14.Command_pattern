# GoF_Csharp_14.Command_Pattern

The Command Pattern is a behavioral design pattern that encapsulates a request as an object, allowing clients to be parameterized with different requests, queued for execution, and logged for auditing or undo/redo purposes. 

The main components of the Command Pattern are:

1. Command: Interface or abstract class defining an operation (execute) that must be implemented by concrete command classes.

2. ConcreteCommand: Classes that implement the Command interface and encapsulate the request along with the receiver (the object that performs the operation).

3. Invoker: Responsible for queuing and executing commands.

4. Receiver: The object that performs the operation associated with a command.

5. Client: Configures the commands and sets up the invoker.

```csharp
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
```

## How to setup Github actions

![Csharp Github actions](https://github.com/luiscoco/GoF_Csharp-14.Command_pattern/assets/32194879/a2a9b6e6-ba38-48b2-82c9-e96be2379596)



