using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Space
{
    public double x, y;
    public double XX
    {
        get
        {
            Console.Write("Введите x: ");
            return x = Convert.ToDouble(Console.ReadLine());
        }
    }
    public double YY
    {
        get
        {
            Console.Write("Введите y: ");
            return y = Convert.ToDouble(Console.ReadLine());
        }
    }
    static public void Print(double spaceship, double spaceship1)
    {
        Console.WriteLine($"Pos: {spaceship} {spaceship1}");
    }
}

class Spaceship : Space
{
    static void Main(string[] args)
        {
            Space spaceship = new Space();
            Print(spaceship.XX, spaceship.YY);
        }
}