namespace SpaceBattle.Lib.Test;

public class UnitTest1
{
    [Fact]
    public void TestPositiveMove()
    {
        Mock<IMovable> movableMock = new Mock<IMovable>();
        ICommand c = new MoveCommand(movableMock.Object);
    }
}