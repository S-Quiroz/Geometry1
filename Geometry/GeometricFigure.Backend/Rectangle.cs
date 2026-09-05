namespace GeometricFigure.Backend;
public class Rectangle : Square
    {
    // Private field
    private double _b;

    // Public property
    public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

    // Constructor 
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

    // Overridden methods
    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);

    // Private validation method    

        private double ValidateB(double b)
        {
            if (b <= 0)
            throw new ArgumentException("El lado B debe ser mayor a cero.");
            return b;
        }
    }

