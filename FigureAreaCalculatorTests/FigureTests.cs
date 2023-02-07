using System;
using System.Threading.Tasks;
using FigureAreaCalculator;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace FigureAreaCalculatorTests;

public class FigureTests
{
    private IFigure? _testObject;
    private ITestOutputHelper _helper;
    private const double Tolerance = 0.01;
    private const int NumberSymbolsAfterComma = 2;
    
    public FigureTests(ITestOutputHelper helper)
    {
        _helper = helper;
    }
    
    [Theory]
    [InlineData(10, 5, 7, 16.25)]
    public void TriangleAreaTest(double a, double b, double c, double result)
    {
        _testObject = new Triangle(new []{a, b, c});
        var testResult = _testObject.CalculateSquare();
        Assert.Equal(result, Math.Round(testResult, NumberSymbolsAfterComma));
        _helper.WriteLine($"Expected: {result}\nActual: {testResult}");
    }
    
    [Theory]
    [InlineData(10, 5, 0)]
    [InlineData(10, 5, -1)]
    [InlineData(10, 1, 1)]
    public void TriangleAreaExceptionsTest(double a, double b, double c)
    {
        var exception = Assert.Throws<ArgumentException>(() => _testObject = new Triangle(new []{a, b, c}));
        _helper.WriteLine($"A = {a}, B = {b}, C = {c}\nException: {exception.Message}");
    }
    
    [Theory]
    [InlineData(10, 314.16)]
    public void CircleAreaTest(double radius, double result)
    {
        _testObject = new Circle(radius);
        var testResult = _testObject.CalculateSquare();
        Assert.Equal(result, Math.Round(testResult, NumberSymbolsAfterComma));
        _helper.WriteLine($"Expected: {result}\nActual: {testResult}");
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CircleAreaExceptionsTest(double radius)
    {
        var exception = Assert.Throws<ArgumentException>(() => _testObject = new Circle(radius));
        _helper.WriteLine($"Radius = {radius}\nException: {exception.Message}");
    }

    [Theory]
    [InlineData(6, 8, 10, true)]
    [InlineData(10, 5, 7, false)]
    public void TriangleRightTest(double a, double b, double c, bool isRight)
    {
        _testObject = new Triangle(new []{a, b, c});
        var testResult = (_testObject as Triangle)!.IsRight(Tolerance);
        Assert.Equal(isRight, testResult);
        _helper.WriteLine($"Expected: {isRight}\nActual: {testResult}");
    }
}