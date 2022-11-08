namespace SpaceBattle.Lib;

public class MoveCommand : ICommand
{
    private readonly IMovable moving;
    public MoveCommand(IMovable obj)
    {
        moving = obj;
    }
    public void execute()
    {
        moving.Position += moving.Velocity;
    }
}