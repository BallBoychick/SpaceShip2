using Moq;
namespace SpaceBattle.Lib.Test;
public class MoveCommandTest
{
    [Fact]
    public void TestPositiveMove()
    {
        // Mock<IMovable> movableMock = new Mock<IMovable>();
        // movable.SetupProperty(i => i.Position, new Vector(12,5));
        // movable.SetupGet<Vector>(i => i.Velocity).Returns(new Vector(-7,3));
        // ICommand c = new MoveCommand(movableMock.Object);

        Mock<IMovable> movableMock = new Mock<IMovable>();
        movableMock.SetupProperty(i => i.Position, new Vector(12, 5));
        movableMock.SetupGet<Vector>(i => i.Velocity).Returns(new Vector(-7, 3));
        ICommand movecommand = new MoveCommand(movableMock.Object);
        movecommand.execute();
        Assert.Equal(new Vector(5, 8), movableMock.Object.Position);
    }
}