namespace GeometryLibrary;

public class Circle : IFigure
{
    public double Radius { get; set; }

    public Circle(CircleInfo info)
    {
        double radius = info.Radius;
        if (radius <= 0)
        {
            throw new InvalidOperationException("Радиус круга не должен быть меньше или равняться нулю");
        }
        Radius = radius;
    }
    
    public double GetSquare()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }
}