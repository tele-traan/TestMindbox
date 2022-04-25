using GeometryLibrary;

namespace ClientApp;

//Добавленная условным пользователем библиотеки новая фигура
public class Rectangle : IFigure
{
    public double Side1 { get; set;}
    public double Side2 { get; set; }

    public Rectangle(RectangleInfo info)
    {
        Side1 = info.Side1;
        Side2 = info.Side2;
    }

    public double GetSquare()
    {
        return Side1 * Side2;
    }
}