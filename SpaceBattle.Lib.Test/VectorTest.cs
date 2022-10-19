namespace SpaceBattle.Lib.Test;
public class VectorTest
{
    [Fact]
    public void VectorTestPositive()
    {
        Vector a = new Vector(2, 3);
        Vector b = new Vector(4, 5);
        Assert.Equal(new Vector(6,8), a + b);
    }
}