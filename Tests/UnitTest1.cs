using System;
using Xunit;
using GeometryLibrary;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void TestTriangleSquare()
    {
        IFigure triangle = Geometry.CreateFigure(new TriangleInfo(4, 5, 7));
        Assert.Equal(Math.Sqrt(96), triangle.GetSquare());
    }

    [Fact]
    public void TestRectangularTriangleSquare()
    {
        IFigure triangle = Geometry.CreateFigure(new TriangleInfo(3, 4, 5));
        Assert.Equal(6, triangle.GetSquare());
    }

    [Fact]
    public void TestCircleSquare()
    {
        IFigure circle = Geometry.CreateFigure(new CircleInfo(10));
        Assert.Equal(314, Math.Round(circle.GetSquare()));
    }

    [Fact]
    public void TestInvalidTriangleThrows()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            IFigure invalidTriangle = Geometry.CreateFigure(new TriangleInfo(3, 3, 7));
            double square = invalidTriangle.GetSquare();
        });
        
        Assert.Throws<InvalidOperationException>(() =>
        {
            IFigure invalidTriangle = Geometry.CreateFigure(new TriangleInfo(-3, 4, 5));
            double square = invalidTriangle.GetSquare();
        });
    }

    [Fact]
    public void TestInvalidCircleThrows()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            IFigure invalidCircle = Geometry.CreateFigure(new CircleInfo(-10));
            double square = invalidCircle.GetSquare();
        });
    }
}