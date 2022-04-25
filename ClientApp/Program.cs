using GeometryLibrary;

namespace ClientApp;
internal class Program
{
    //Пример использования библиотеки: программа, написанная условным пользователем
    static void Main()
    {
        
        FigureInfo? figureInfo;
        Console.WriteLine("Выберите тип фигуры\n1: Круг\n2: Треугольник\n3: Прямоугольник");

        int choice = int.Parse(Console.ReadLine()!);
        switch ((FigureType) choice)
        {
            case FigureType.Circle:
                Console.Write("Введите радиус круга: ");
                double radius = double.Parse(Console.ReadLine()!);
                figureInfo = new CircleInfo(radius);
                break;
            
            case FigureType.Triangle:
                Console.Write("Введите стороны треугольника через запятую: ");
                var triangleSides = Console.ReadLine()!
                    .Split(",")
                    .Select(s => double.Parse(s))
                    .ToArray();
                try
                {
                    figureInfo = new TriangleInfo(triangleSides[0], triangleSides[1], triangleSides[2]);
                }
                catch (InvalidOperationException ioe)
                {
                    figureInfo = null;
                    Console.WriteLine(ioe.Message);
                }
                break;
            
            case FigureType.Rectangle:
                Console.Write("Введите две стороны прямоугольника через запятую: ");
                var rectangleSides = Console.ReadLine()!
                    .Split(",")
                    .Select(s => double.Parse(s))
                    .ToArray();
                figureInfo = new RectangleInfo(rectangleSides[0], rectangleSides[1]);
                break;
            default:
                figureInfo = null;
                break;
        }

        IFigure? figure = figureInfo is null ? null : Geometry.CreateFigure(figureInfo);
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