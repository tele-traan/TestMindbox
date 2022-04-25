namespace GeometryLibrary;

public class TriangleInfo : FigureInfo
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public TriangleInfo(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override IFigure CreateFigure()
    {
        return new Triangle(this);
    }
}