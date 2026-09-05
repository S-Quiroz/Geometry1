namespace GeometricFigure.Backend;

public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        D = d;
    }

    // Expected area in sample uses (A + B) * H (no division by 2)
    public override double GetArea() => (A + B) * H;
    public override double GetPerimeter() => A + B + C + D;

    private double ValidateD(double d)
    {
        if (d <= 0) throw new ArgumentException("El lado D debe ser mayor a cero.");
        return d;
    }
}
