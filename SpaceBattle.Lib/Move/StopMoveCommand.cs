namespace SpaceBattle.Lib;

public class StopMoveCommand : ICommand
{
    public StopMoveCommand(object obj)
    {

    }
    void execute()
    {
        ICommand rmc = IoC<ICommand>();
        IoC<ICommand>("UObject.SetupProperty", obj, MoveOperation, rc);
        q.push(rc);
    }
}
