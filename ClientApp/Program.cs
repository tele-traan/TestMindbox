using GeometryLibrary;

namespace ClientApp;
internal class Program
{
    //Пример использования библиотеки: программа, написанная условным пользователем
    static void Main()
    {

        FigureInfo? info;
        Console.WriteLine("Выберите тип фигуры\n1: Круг\n2: Треугольник\n3: Прямоугольник");

        var choice = int.Parse(Console.ReadLine()!);
        switch ((FigureType) choice)
        {
            case FigureType.Circle:
                Console.Write("Введите радиус круга: ");
                var radius = double.Parse(Console.ReadLine()!);
                info = new CircleInfo(radius);
                break;
            
            case FigureType.Triangle:
                Console.Write("Введите три стороны треугольника через запятую: ");
                var triSides = Console.ReadLine()?
                    .Split(",")
                    .Select(s => double.Parse(s))
                    .ToArray();
                info = new TriangleInfo(triSides);
                break;
            
            case FigureType.Rectangle:
                Console.WriteLine("Введите две стороны прямоугольника через запятую: ");
                var rectSides = Console.ReadLine()?
                    .Split(",")
                    .Select(s=>double.Parse(s))
                    .ToArray();
                info = new RectangleInfo(rectSides);
                break;
            
            default:
                info = null;
                break;
        }

        IFigure? figure;
        try
        {
            figure = info?.CreateFigure();
        }
        catch (Exception e)
        {
            figure = null;
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }

        Console.WriteLine($"Площадь вашей фигуры: {figure?.GetSquare() ?? 0.0}");
        Console.ReadKey();
    }
}

internal enum FigureType
{
    Circle = 1,
    Triangle = 2,
    Rectangle = 3
}