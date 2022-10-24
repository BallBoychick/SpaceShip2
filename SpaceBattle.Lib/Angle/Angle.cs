namespace SpaceBattle.Lib;
public class Angle
{
    public int numa;
    public int dena;

    public Angle(int angle1, int angle2)
    {
        numa = angle1;
        dena = angle2;
        if (dena == 0)
        {
            throw new System.DivideByZeroException();
        }
    }
    public override string ToString()
    {
        return numa.ToString() + "/" + dena.ToString();
    }
    public static Angle operator +(Angle angle1, Angle angle2)
    {
        int z = 0, xa = 0, xb = 0;
        if (angle2.dena % angle1.dena == 0)
        {
            z = angle2.dena;
            xb = angle2.numa;
            xa = angle1.numa * (angle2.dena / angle1.dena);
        }
        else if (angle1.dena % angle2.dena == 0)
        {
            z = angle1.numa;
            xb = angle2.numa * (angle1.dena / angle2.dena);
            xa = angle1.numa;
            return new Angle((xb + xa) / z, z);
        }
        else
        {
            z = angle1.dena * angle2.dena;
            xa = angle1.numa * angle2.dena;
            xb = angle2.numa * angle1.dena;
        }
        return new Angle(xa + xb, z);
    }
    public static bool operator ==(Angle angle1, Angle angle2)
    {
        return (decimal)angle1.numa * angle2.dena == (decimal)angle2.numa * angle1.dena;
    }
    public static bool operator !=(Angle angle1, Angle angle2)
    {
        return (!(angle1 == angle2));
    }
    public override bool Equals(object angle)
    {
        if (angle == null || angle.GetType() != GetType())
            return false;
        Angle f = (Angle)angle;
        return (this == f);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(numa, dena);
    }
}