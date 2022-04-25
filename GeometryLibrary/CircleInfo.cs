namespace GeometryLibrary;

public class CircleInfo : FigureInfo
{
    public double Radius { get; set; }

    public CircleInfo(double radius)
    {
        Radius = radius;
    }
    public override IFigure CreateFigure()
    {
        return new Circle(this);
    }
}