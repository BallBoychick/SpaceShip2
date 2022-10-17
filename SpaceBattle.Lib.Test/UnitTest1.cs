namespace SpaceBattle.Lib.Test;
public class MoveCommandTest
{
    [Fact]
    public void MoveCommandTestPositive()
    {
        // Arrange
        Mock<IMovable> movableMock = new Mock<IMovable>();
        movableMock.SetupProperty(i => i.Position, new Vector(12, 5));
        movableMock.SetupGet(i => i.Velocity).Returns(new Vector(-7, 3));
        ICommand movecommand = new MoveCommand(movableMock.Object);
        // Act
        movecommand.execute();
        // Assert
        Assert.Equal(new Vector(5, 8), movableMock.Object.Position);
    }

    [Fact]
    public void MoveCommandTestCantGetPosition()
    {
        // Arrange
        Mock<IMovable> movableMock = new Mock<IMovable>();
        movableMock.SetupProperty(i => i.Position, new Vector(12, 5));
        movableMock.SetupGet<Vector>(i => i.Velocity).Throws<ArgumentException>();
        ICommand movecommand = new MoveCommand(movableMock.Object);
        //Assert
        Assert.Throws<ArgumentException>(() => movecommand.execute());
    }

    [Fact]
    public void MoveCommandTestCantGetInstantaneousVelocity()
    {
        // Arrange
        Mock<IMovable> movableMock = new Mock<IMovable>();
        movableMock.SetupProperty(i => i.Position, new Vector(12, 5));
        movableMock.SetupGet<Vector>(i => i.Velocity).Throws<Exception>();
        ICommand movecommand = new MoveCommand(movableMock.Object);
        // Assert
        Assert.Throws<Exception>(() => movecommand.execute());
    }

    [Fact]
    public void MoveCommandTesCantSetPosition()
    {
        // Arrange
        Mock<IMovable> movableMock = new Mock<IMovable>();
        movableMock.SetupProperty(i => i.Position, new Vector(12, 5));
        movableMock.SetupSet<Vector>(i => i.Position = It.IsAny<Vector>()).Throws<ArgumentException>();
        movableMock.SetupGet<Vector>(i => i.Velocity).Returns(new Vector(-7, 3));
        ICommand movecommand = new MoveCommand(movableMock.Object);
        // Assert
        Assert.Throws<ArgumentException>(() => movecommand.execute());
    }
}

public class RotateCommandTest
{
    [Fact]
    public void RotateCommandTestPositive()
    {
        // Arrange
        Mock<IRotatable> rotatableMock = new Mock<IRotatable>();
        rotatableMock.SetupProperty(i => i.Angle, 45);
        rotatableMock.SetupGet<int>(i => i.AngleVelocity).Returns(90);
        ICommand rotatecommand = new RotateCommand(rotatableMock.Object);
        // Act
        rotatecommand.execute();
        // Assert
        Assert.Equal(135, rotatableMock.Object.Angle);
    }

    [Fact]
    public void RotateCommandTestCantGetVelocity()
    {
        // Arrange
        Mock<IRotatable> rotatableMock = new Mock<IRotatable>();
        rotatableMock.SetupProperty(i => i.Angle, 45);
        rotatableMock.SetupGet<int>(i => i.AngleVelocity).Throws<ArgumentException>();
        ICommand rotatecommand = new RotateCommand(rotatableMock.Object);
        //Assert
        Assert.Throws<ArgumentException>(() => rotatecommand.execute());
    }

    [Fact]
    public void RotateCommandTestCantGetInstantaneousAngleVelocity()
    {
        // Arrange
        Mock<IRotatable> rotatableMock = new Mock<IRotatable>();
        rotatableMock.SetupProperty(i => i.Angle, 45);
        rotatableMock.SetupGet<int>(i => i.AngleVelocity).Throws<Exception>();
        ICommand rotatecommand = new RotateCommand(rotatableMock.Object);
        // Assert
        Assert.Throws<Exception>(() => rotatecommand.execute());
    }

    [Fact]
    public void MoveCommandTesCantSetPosition()
    {
        // Arrange
        Mock<IRotatable> rotatableMock = new Mock<IRotatable>();
        rotatableMock.SetupProperty(i => i.Angle, 45);
        rotatableMock.SetupSet<int>(i => i.Angle = It.IsAny<int>()).Throws<ArgumentException>();
        rotatableMock.SetupGet<int>(i => i.AngleVelocity).Returns(90);
        ICommand rotatecommand = new RotateCommand(rotatableMock.Object);
        // Assert
        Assert.Throws<ArgumentException>(() => rotatecommand.execute());
    }
}