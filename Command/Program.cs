using Command;

public interface ICommand
{
    void Execute();  // Выполнение команды
    void Undo();     // Отмена команды
}
public class Program
{
    public static void Main(string[] args)
    {
        TextEditor textEditor = new TextEditor();
        CommandHistory commandHistory = new CommandHistory();

        ICommand insertCommand1 = new InsertTextCommand(textEditor, "Hello ");
        ICommand insertCommand2 = new InsertTextCommand(textEditor, "world!");

        insertCommand1.Execute();
        commandHistory.Push(insertCommand1);

        insertCommand2.Execute();
        commandHistory.Push(insertCommand2);

        ICommand undoCommand = commandHistory.Pop();
        undoCommand.Undo();

        ICommand deleteCommand = new DeleteTextCommand(textEditor, 5);
        deleteCommand.Execute();
        commandHistory.Push(deleteCommand);

        undoCommand = commandHistory.Pop();
        undoCommand.Undo();
    }
}

