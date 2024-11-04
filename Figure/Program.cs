using System;
using System.Drawing;

abstract class Figure
{
    // Абстрактний метод для обчислення площі
    public abstract double CalculateArea();

    // Абстрактний метод для обчислення периметра
    public abstract double CalculatePerimeter();
}

// Клас Коло, який успадковує клас Фігура
class circle : Figure
{
    public double Radius { get; set; }

    public circle(double radius)
    {
        Radius = radius;
    }

    // Реалізація методу для обчислення площі кола
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Реалізація методу для обчислення периметра кола
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Клас Прямокутник, який успадковує клас Фігура
class rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Реалізація методу для обчислення площі прямокутника
    public override double CalculateArea()
    {
        return Width * Height;
    }

    // Реалізація методу для обчислення периметра прямокутника
    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта Коло і обчислення площі та периметра
        circle circle = new circle(5.0);
        Console.WriteLine("Коло:");
        Console.WriteLine($"Радіус: {circle.Radius}");
        Console.WriteLine($"Площа: {circle.CalculateArea()}");
        Console.WriteLine($"Периметр: {circle.CalculatePerimeter()}");

        // Створення об'єкта Прямокутник і обчислення площі та периметра
        rectangle rectangle = new rectangle(4.0, 6.0);
        Console.WriteLine("\nПрямокутник:");
        Console.WriteLine($"Ширина: {rectangle.Width}");
        Console.WriteLine($"Висота: {rectangle.Height}");
        Console.WriteLine($"Площа: {rectangle.CalculateArea()}");
        Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}");
    }
}