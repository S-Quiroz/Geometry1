namespace GeometricFigure.Backend;

    public class Circle : GeometricFigure
    {
        // Field private
        private double _r;

        // Public ownership
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        // builder
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        // Method
        public override double GetArea() => Math.PI * Math.Pow(R, 2);
        public override double GetPerimeter() => 2 * Math.PI * R;

        // Private validation method
        private double ValidateR(double r)
        {
            if (r <= 0)
            throw new ArgumentException("El radio debe ser mayor a cero.");
            return r;
        }
    }





