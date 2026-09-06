namespace GeometricFigure.Backend;

public abstract class GeometricFigure
{
    public string name { get; set; } = string.Empty;
    public GeometricFigure(string name)
    {
        this.name = name;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "{0,-15} => Area.....: {1,12:F5}\tPerimeter: {2,10:F5}",
            name, GetArea(), GetPerimeter());
    }
}