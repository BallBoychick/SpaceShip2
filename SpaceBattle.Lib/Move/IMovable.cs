namespace SpaceBattle.Lib;

public interface IMovable
{
    Vector Position
    {
        get;
        set;
    }
    Vector Velocity
    {
        get;
    }
}