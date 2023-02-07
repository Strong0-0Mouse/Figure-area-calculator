using System;

namespace FigureAreaCalculator;

public class Circle : IFigure
{
    private readonly double _radius;

    /// <summary>
    /// Circle
    /// </summary>
    /// <param name="radius">The radius of the circle must be strictly positive</param>
    /// <exception cref="ArgumentException">Received radius <= 0</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Invalid radius");
        
        _radius = radius;
    }
    
    /// <summary>
    /// Method for calculating the area of a circle
    /// </summary>
    /// <returns>Circle area</returns>
    public double CalculateSquare()
    {
        return Math.PI * _radius * _radius;
    }
}