using GeometryLibrary;

namespace ClientApp;

public class RectangleInfo : FigureInfo
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public RectangleInfo(double side1, double side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

    public override IFigure CreateFigure()
    {
        return new Rectangle(this);
    }
}