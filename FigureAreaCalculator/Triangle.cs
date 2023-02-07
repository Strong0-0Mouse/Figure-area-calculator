using System;
using System.Collections.Generic;
using System.Linq;

namespace FigureAreaCalculator;

public class Triangle : IFigure
{
    private readonly List<double> _sides;
    
    /// <summary>
    /// Triangle
    /// </summary>
    /// <param name="sides">The triangle must have exactly 3 strictly positive sides and exist with the given parameters</param>
    /// <exception cref="ArgumentException">Received invalid triangle sides</exception>
    public Triangle(IEnumerable<double> sides)
    {
        var enumerable = sides.ToList();
        if (enumerable.Count != 3 || enumerable.Any(s => s <= 0))
            throw new ArgumentException("Invalid sides");
        
        _sides = enumerable.ToList();
        
        var a = _sides[0];
        var b = _sides[1];
        var c = _sides[2];

        if (a + b <= c || b + c <= a || a + c <= b)
            throw new ArgumentException("Triangle does not exist");
    }
    
    /// <summary>
    /// Method for calculating the area of a triangle
    /// </summary>
    /// <returns>Triangle area</returns>
    public double CalculateSquare()
    {
        var a = _sides[0];
        var b = _sides[1];
        var c = _sides[2];

        var semiPerimeter = (a + b + c) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));  
    }

    /// <summary>
    /// Method for recognizing a right triangle
    /// </summary>
    /// <param name="tolerance">Tolerance when comparison double numbers</param>
    /// <returns>Is it a right triangle or not</returns>
    public bool IsRight(double tolerance)
    {
        var a = _sides[0];
        var b = _sides[1];
        var c = _sides[2];

        return Math.Abs(a * a + b * b - c * c) < tolerance || 
               Math.Abs(a * a + c * c - b * b) < tolerance ||
               Math.Abs(c * c + b * b - a * a) < tolerance;
    }
}