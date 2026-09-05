namespace GeometricFigure.Backend;
public class Triangle : Rectangle
{
 // Private fields
    private double _c;
    private double _h;

 // Properties públic c
    public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

 // Properties públic h
    public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }
    // Constructor 
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }
    // Overridden methods
    // Use base B as the triangle base so area = (base * height) / 2
    public override double GetArea() => (B * H) / 2.0;
    public override double GetPerimeter() => A + B + C;

    // Private validation methods
    private double ValidateC(double c)
        {
            if (c <= 0)
            throw new ArgumentException("El lado C debe ser mayor a cero.");
            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
            throw new ArgumentException("La altura H debe ser mayor a cero.");
            return h;
        }
    }

