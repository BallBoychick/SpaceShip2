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
// class Move(private m: IMovable)
// {
//     public void execute()
//     {
//         m.Position += m.Velocity;
//     }
// }