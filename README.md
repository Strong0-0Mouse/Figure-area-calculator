# Figure area calculator

Данная библиотека высчитывает площади круга и треугольника

Актуальная последняя версия: 1.0.0

Target framework: net6.0

# API Reference

## IFigure

### CalculateSquare() | return double
---

## Triangle

### CalculateSquare() | return double

### IsRight() | return bool
---

## Circle

### CalculateSquare() | return double

# Модели

## IFigure - интефейс абстрактной фигуры, которая должна уметь находить свою площадь

## Circle - класс круга, реализующий интерфейс IFigure 
```csharp
public Circle(double radius)
```

## Triangle - класс треугольника, реализующий интерфейс IFigure 
```csharp
public Triangle(double sideA, double sideB, double sideC)
```