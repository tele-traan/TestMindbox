using GeometryLibrary;

namespace ClientApp;

//Добавленная условным пользователем библиотеки новая фигура
public class Rectangle : IFigure
{
    public double Side1 { get; set;}
    public double Side2 { get; set; }

    public Rectangle(params object?[]? parameters)
    {
        if (parameters is null || parameters.Any(p => p is not double) || parameters.Length < 2)
        {
            throw new ArgumentException("Для сторон прямоугольника были введены некорректные значения");
        }

        Side1 = (double) parameters[0]!;
        Side2 = (double) parameters[0]!;
    }

    public double GetSquare()
    {
        return Side1 * Side2;
    }
}