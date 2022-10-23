namespace SpaceBattle.Lib;

public class StartMoveCommand : ICommand
{
    public StartMoveCommand(object obj)
    {

    }
    void execute()
    {
        ICommand rmc = IoC<ICommand>();
        IoC<ICommand>("UObject.SetupProperty", obj, MoveOperation, rc);
        q.push(rc);
    }
}


// public static class IoC
//     {
//         public static T Resolve<T>(string key, params object[] args)
//         {
//             // TODO IoC Container Implementation
//             return default;
//         }
//     }