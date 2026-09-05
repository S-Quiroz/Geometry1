namespace GeometricFigure.Backend;

public class Parallelogram : Rectangle
    {
        private double _h;

    // Properties
    public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

    // Constructor 
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }
    // Overridden methods
    public override double GetArea() => B * H;
    private double ValidateH(double h)
        {
            if (h <= 0)
            throw new ArgumentException("La altura H debe ser mayor a cero.");
            return h;
        }
    }


