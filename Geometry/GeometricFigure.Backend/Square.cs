namespace GeometricFigure.Backend;

    public class Square : GeometricFigure
{
    // Field 
    private double _a;

    // Public property 
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Constructor 
    public Square(string name, double a) : base(name)
    {
        A = a;
    }
    // Methods
    public override double GetArea() => Math.Pow(A, 2);
    public override double GetPerimeter() => 4 * A;
    private double ValidateA(double a)
    {
        if (a <= 0)
        throw new ArgumentException("El lado A debe ser mayor a cero.");
        return a;
    }
}



