namespace GeometryLibrary;

public class Circle : IFigure
{
    public double Radius { get; set; }

    public Circle(params object?[]? parameters)
    {
        if (parameters?[0] is not double
            and not float 
            and not int)
        {
            throw new ArgumentException("Для радиуса круга было введено некорректное значение");
        }

        var radius = Convert.ToDouble(parameters[0]!);
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