namespace SpaceBattle.Lib;

public class RotateCommand : ICommand
{
    private readonly IRotatable rotating;
    public RotateCommand(IRotatable obj)
    {
        rotating = obj;
    }
    public void execute()
    {
        rotating.Angle += rotating.AngleVelocity;
    }
}