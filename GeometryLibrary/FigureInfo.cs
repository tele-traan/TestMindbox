using BindingFlags = System.Reflection.BindingFlags;

namespace GeometryLibrary;

public abstract class FigureInfo//<T> where T: class, IFigure
{
    protected readonly object?[]? Parameters;
    protected FigureInfo(params object?[]? parameters)
    {
        Parameters = parameters;
    }

    public abstract IFigure CreateFigure();
}