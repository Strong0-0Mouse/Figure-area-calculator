# Figure area calculator

Данная библиотека высчитывает площади круга и треугольника

Актуальная последняя версия: 1.0.0

Target framework: net6.0

# API Reference

## IFigure

```csharp
CalculateSquare() | return double
```
---

## Triangle

```csharp
CalculateSquare() | return double
```

```csharp
IsRight() | return bool
```
---

## Circle

```csharp
CalculateSquare() | return double
```
---
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