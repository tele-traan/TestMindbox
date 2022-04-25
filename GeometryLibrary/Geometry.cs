namespace GeometryLibrary;
public static class Geometry
{
    public static IFigure CreateFigure(FigureInfo info)
    {
        return info.CreateFigure();
    }
}