namespace SpaceBattle.Lib;

public interface IRotatable
{
    public int Angle
    {
        get;
        set;
    }
    public int AngleVelocity
    {
        get;
    }
}