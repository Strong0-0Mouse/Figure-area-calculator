using System;

namespace FigureAreaCalculator;

public class Triangle : IFigure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    
    /// <summary>
    /// Triangle
    /// </summary>
    /// <param name="sideA">Strictly positive side</param>
    /// <param name="sideB">Strictly positive side</param>
    /// <param name="sideC">Strictly positive side</param>
    /// <exception cref="ArgumentException">Received invalid triangle sides</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Invalid sides");
        
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        if (_sideA + _sideB <= _sideC || _sideB + _sideC <= _sideA || _sideA + _sideC <= _sideB)
            throw new ArgumentException("Triangle does not exist");
    }
    
    /// <summary>
    /// Calculating the area of a triangle
    /// </summary>
    /// <returns>Triangle area</returns>
    public double CalculateSquare()
    {
        var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));  
    }

    /// <summary>
    /// Recognizing a right triangle
    /// </summary>
    /// <param name="tolerance">Tolerance when comparison double numbers</param>
    /// <returns>Is it a right triangle or not</returns>
    public bool IsRight(double tolerance)
    {
        return Math.Abs(_sideA * _sideA + _sideB * _sideB - _sideC * _sideC) < tolerance || 
               Math.Abs(_sideA * _sideA + _sideC * _sideC - _sideB * _sideB) < tolerance ||
               Math.Abs(_sideC * _sideC + _sideB * _sideB - _sideA * _sideA) < tolerance;
    }
}