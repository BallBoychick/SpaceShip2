namespace SpaceBattle.Lib.Test;
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
    public void RotateCommandTesCantSetPosition()
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