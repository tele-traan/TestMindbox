using GeometryLibrary;

namespace ClientApp;

public class RectangleInfo : FigureInfo
{
    public RectangleInfo(params object?[]? parameters): base(parameters){}
    public override IFigure CreateFigure()
    {
        return new Rectangle(Parameters);
    }
}