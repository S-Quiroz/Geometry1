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
        return $"{name,-15} => Area.....: {GetArea(),12:N5}\tPerimeter: {GetPerimeter(),10:F5}";
    }
}