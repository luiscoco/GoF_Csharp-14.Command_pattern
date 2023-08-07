# GoF_Csharp_14.Command_Pattern

The Command Pattern is a behavioral design pattern that encapsulates a request as an object, allowing clients to be parameterized with different requests, queued for execution, and logged for auditing or undo/redo purposes. The main components of the Command Pattern are:

Command: Interface or abstract class defining an operation (execute) that must be implemented by concrete command classes.
ConcreteCommand: Classes that implement the Command interface and encapsulate the request along with the receiver (the object that performs the operation).
Invoker: Responsible for queuing and executing commands.
Receiver: The object that performs the operation associated with a command.
Client: Configures the commands and sets up the invoker.


