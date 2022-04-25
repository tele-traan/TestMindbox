namespace GeometryLibrary;


public class Triangle : IFigure
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(TriangleInfo info)
    {
        double side1 = info.Side1,
            side2 = info.Side2,
            side3 = info.Side3;
        
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new InvalidOperationException("Стороны треугольника не должны быть меньше или равняться нулю");
        }
        if (side1 + side2 <= side3
            || side2 + side3 <= side1
            || side1 + side3 <= side2)
        {
            throw new InvalidOperationException(
                "Сторона треугольника не может быть больше суммы двух других сторон");
        }
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }
    public double GetSquare()
    {
        double side1Sq = Math.Pow(Side1, 2),
            side2Sq = Math.Pow(Side2, 2),
            side3Sq = Math.Pow(Side3, 2);

        if (side1Sq.CompareTo(side2Sq + side3Sq) == 0)
        {
            return Side1 * Side2 / 2;
        }

        if (side2Sq.CompareTo(side1Sq + side3Sq) == 0)
        {
            return Side1 * Side3 / 2;
        }
        if(side3Sq.CompareTo(side1Sq + side2Sq) == 0)
        {
            return Side1 * Side2 / 2;
        }
        var halfPerimeter = (Side1 + Side2 + Side3) / 2;
        var square = Math.Sqrt(
            halfPerimeter
            * (halfPerimeter - Side1)
            * (halfPerimeter - Side2)
            * (halfPerimeter - Side3)
        );
        return square;
    }
}
