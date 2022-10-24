namespace SpaceBattle.Lib.Test;
public class VectorTest
{
    [Fact]
    public void VectorTestPositivePlus()
    {
        Vector a = new Vector(2, 3);
        Vector b = new Vector(4, 5);
        Assert.Equal(new Vector(6, 8), a + b);
    }

    [Fact]
    public void VectorNegativeSizeTest()
    {
        Vector a = new Vector(2, 3);
        Vector b = new Vector(4, 5, 6);
        Assert.Throws<ArgumentException>(() => (a + b));
    }

    [Fact]
    public void VectorPositivetoStringTest()
    {
        Vector a = new Vector(2, 3);
        String stringResult = a.ToString();
        Assert.Equal("Vector(2, 3)", stringResult);
    }

    [Fact]
    public void VectorTestPositiveEquality()
    {
        Vector a = new Vector(2, 2);
        Vector b = new Vector(2, 2);
        Assert.True(a == b);
    }
    [Fact]
    public void VectorTestNegativeEquality()
    {
        Vector a = new Vector(2, 2);
        Vector b = new Vector(3, 4, 5);
        Assert.False(a == b);
    }

    [Fact]
    public void VectorNegativeEqualTest()
    {
        Vector a = new Vector(5, 5);
        Vector b = new Vector(25, 5);
        Assert.True(a != b);
    }

    [Fact]
    public void VectorPositiveeEqvals()
    {
        Vector a = new Vector(5, 5);
        Vector b = new Vector(5, 5);
        Assert.True(a.Equals(b));
    }

    [Fact]
    public void VectorGetTest()
    {
        Vector a = new Vector(5, 5);
        Assert.Equal(5, a[0]);
    }

    [Fact]
    public void VectorSetTest()
    {
        Vector a = new Vector(5, 5);
        a[0] = 3;
        Assert.Equal(3, a[0]);
    }

    [Fact]
    public void VectornotEqvals()
    {
        Vector a = new Vector(5, 5);
        int b = 3;
        Assert.False(a.Equals(b));
    }

    [Fact]
    public void GetHashCodeVectorTest()
    {
        Vector a = new Vector(1, 2);
        Vector b = new Vector(1, 2);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }
}