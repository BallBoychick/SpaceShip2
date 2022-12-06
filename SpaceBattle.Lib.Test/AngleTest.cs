namespace SpaceBattle.Lib.Test;
public class AngleTest
{
    [Fact]
    public void AngleTestSum()
    {
        Angle a = new Angle(1, 9);
        Angle b = new Angle(2, 9);
        Angle c = new Angle(5, 9);
        Assert.Equal(new Angle(1, 3), a + b);
        Assert.Equal(new Angle(7, 9), c + b);
        Assert.Equal(new Angle(7, 9), b + c);
    }
    [Fact]
    public void AngleTestEqual()
    {
        Assert.Throws<DivideByZeroException>(() => new Angle(1, 0));
    }
    [Fact]
    public void AngleEqualEqualTest()
    {
        Angle a = new Angle(1, 3);
        Angle b = new Angle(2, 3);
        Assert.True(a != b);
    }
    [Fact]
    public void AngleNotEqualTest()
    {
        Angle a = new Angle(1, 3);
        Angle b = new Angle(1, 3);
        Assert.True(a == b);

    }
    [Fact]
    public void VectorPositiveNotEqualsTest()
    {
        Angle a = new Angle(45, 1);
        Assert.Equal("45/1", a.ToString());
    }
    [Fact]
    public void GetHashCodeTest()
    {
        Angle a = new Angle(1, 2);
        Angle b = new Angle(1, 2);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }
    [Fact]
    public void EqualsNegativeTest()
    {
        Angle a = new Angle(1, 2);
        Angle c = new Angle(2, 1);
        int b = 3;
        Assert.False(a.Equals(b));
        Assert.False(a.Equals(c));
    }
};