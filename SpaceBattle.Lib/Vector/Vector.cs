namespace SpaceBattle.Lib;
public class Vector
{
    private double[] coords;
    public int Size;
    public Vector(params double[] args)
    {
        coords = args;
        Size = args.Length;
    }
    public override string ToString()
    {
        string str_v = "Vector(";
        for (int i = 0; i < Size; i++)
        {
            str_v += coords[i].ToString();
            if (i != Size - 1) str_v += ", ";
            else str_v += ")";
        }
        return str_v;
    }
    public static Vector operator +(Vector a, Vector b)
    {
        if (a.Size != b.Size) throw new System.ArgumentException();
        for (int i = 0; i < a.Size; i++)
        {
            a.coords[i] += b.coords[i];
        }
        return a;
    }
    public static bool operator ==(Vector a, Vector b)
    {
        if (a.Size != b.Size) return false;
        for (int i = 0; i < a.Size; i++) if (a.coords[i] != b.coords[i]) return false;
        return true;
    }
    public static bool operator !=(Vector a, Vector b)
    {
        return !(a == b);
    }
    public double this[int i]
    {
        get => coords[i];
        set => coords[i] = value;
    }
    public override bool Equals(object? obj)
    {
        return obj is Vector v && coords.SequenceEqual(v.coords);
    }
    public override int GetHashCode() =>
       coords.Aggregate(0, (total, next) => HashCode.Combine(total, next));
}
