namespace GeometryLibrary;

public class CircleInfo : FigureInfo
{
    public CircleInfo(params object?[]? parameters) : base(parameters) {}
    public override IFigure CreateFigure()
    {
        return new Circle(Parameters);
    }
}