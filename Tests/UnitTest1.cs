using System;
using Xunit;
using GeometryLibrary;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void TestTriangleSquare()
    {
        IFigure triangle = new TriangleInfo(4, 5, 7).CreateFigure();
        Assert.Equal(Math.Sqrt(96), triangle.GetSquare());
    }

    [Fact]
    public void TestRectangularTriangleSquare()
    {
        IFigure triangle = new TriangleInfo(3, 4, 5).CreateFigure();
        Assert.Equal(6, triangle.GetSquare());
    }

    [Fact]
    public void TestCircleSquare()
    {
        IFigure circle = new CircleInfo(10).CreateFigure();
        Assert.Equal(314, Math.Round(circle.GetSquare()));
    }
    
    [Fact]
    public void TestInvalidTriangleThrows()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            IFigure invalidTriangle = new TriangleInfo(3, 3, 7).CreateFigure();
            double square = invalidTriangle.GetSquare();
        });
        
        Assert.Throws<InvalidOperationException>(() =>
        {
            IFigure invalidTriangle = new TriangleInfo(-3, 4, 5).CreateFigure();
            double square = invalidTriangle.GetSquare();
        });
    }

    [Fact]
    public void TestInvalidCircleThrows()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            
            IFigure invalidCircle = new CircleInfo(-10).CreateFigure();
            double square = invalidCircle.GetSquare();
        });
    }

    [Fact]
    public void TestInvalidParametersTypesThrows()
    {
        var invalidFunctions = new Action[]
        {
            () =>
            {
                IFigure invalidTriangle = new TriangleInfo("string", null, DateTime.Now).CreateFigure();
                double square = invalidTriangle.GetSquare();
            },
            () =>
            {
                IFigure invalidCircle = new CircleInfo("string").CreateFigure();
                double square = invalidCircle.GetSquare();
            }
        };
        
        foreach(var function in invalidFunctions)
        {
            Assert.Throws<ArgumentException>(function);
        }
    }
}