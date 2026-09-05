namespace GeometricFigure.Backend;
    public class Kite : Rhombus
    {
    // Field 
     private double _b;

    // Public property
    public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

    // Constructor 
        public Kite(string name, double a, double b, double d1, double d2)
            : base(name, a, d1, d2)
        {
            B = b;
        }

    // Method
    public override double GetArea() => (D1 * D2) / 2.0;
    public override double GetPerimeter() => 2 * (A + B);
    private double ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("El lado B debe ser mayor a cero.");
            return b;
        }
    }



