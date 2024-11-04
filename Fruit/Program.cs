using System;

class Fruit
{
    // Поле для зберігання назви фрукта
    public string Name { get; set; }

    // Конструктор 
    public Fruit(string name)
    {
        Name = name;
    }

    // Метод для виведення інформації про фрукт
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Назва фрукта: {Name}");
    }
}

// Клас Яблуко, який успадковує базовий клас Фрукт
class Apple : Fruit
{
    public string Variety { get; set; }  // Поле для сорту яблука
    public string Color { get; set; }    // Поле для кольору яблука

    // Конструктор для ініціалізації полів класу
    public Apple(string name, string variety, string color) : base(name)
    {
        Variety = variety;
        Color = color;
    }

    // Перевизначення методу для виведення інформації про яблуко
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Сорт: {Variety}");
        Console.WriteLine($"Колір: {Color}");
    }
}

// Клас Груша, який успадковує базовий клас Фрукт
class Pear : Fruit
{
    public string Variety { get; set; }  // Поле для сорту груші
    public string Color { get; set; }    // Поле для кольору груші

    // Конструктор для ініціалізації полів класу
    public Pear(string name, string variety, string color) : base(name)
    {
        Variety = variety;
        Color = color;
    }

    // Перевизначення методу для виведення інформації про грушу
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Сорт: {Variety}");
        Console.WriteLine($"Колір: {Color}");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу Фрукт
        Fruit fruit = new Fruit("Фрукт");
        fruit.PrintInfo();

        Console.WriteLine("\n--- Яблуко ---");
        // Створення об'єкта класу Яблуко
        Apple apple = new Apple("Яблуко", "Гала", "Червоний");
        apple.PrintInfo();

        Console.WriteLine("\n--- Груша ---");
        // Створення об'єкта класу Груша
        Pear pear = new Pear("Груша", "Конференція", "Зелений");
        pear.PrintInfo();
    }
}