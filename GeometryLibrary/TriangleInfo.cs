namespace GeometryLibrary;

public class TriangleInfo : FigureInfo
{
    public TriangleInfo(params object?[]? parameters) : base(parameters) { }
    public override IFigure CreateFigure()
    {
        return new Triangle(Parameters);
    }
}