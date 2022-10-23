namespace SpaceBattle.Lib;

public class RepeatMoveCommand : ICommand
{
    public RepeatMoveCommand(object obj)
    {
        
    }
    execute()
    {
        ICommand c = obj.get_property("MoveOperation");
        c.execute();
    }
}