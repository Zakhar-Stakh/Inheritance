using System;

public abstract class Animal
{
    // Автозгенеровані властивості
    public float Weight { get; set; }
    public string Color { get; set; }

    // Конструктор класу Animal
    public Animal(string color, float weight)
    {
        Color = color;
        Weight = weight;
    }

    // Абстрактний метод MakeSound
    public abstract string MakeSound();
}

public abstract class AnimalWithTail : Animal
{
    // Автозгенерована властивість для довжини хвоста
    public float TailLength { get; set; }

    // Конструктор класу AnimalWithTail
    public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
    {
        TailLength = tailLength;
    }
}

public class Cat : AnimalWithTail
{
    // Конструктор класу Cat
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength) { }

    // Приватний метод для муркотіння
    private string Purr() => "purrrrrrrr ";

    // Приватний метод для мяукання
    private string Meow() => "Meow";

    // Перевизначення методу MakeSound
    public override string MakeSound() => Purr() + Meow();

    // Перевизначення методу ToString
    public override string ToString() =>
        $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
}

public class Dog : AnimalWithTail
{
    // Конструктор класу Dog
    public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength) { }

    // Перевизначення методу MakeSound
    public override string MakeSound() => "Woof";

    // Перевизначення методу ToString
    public override string ToString() =>
        $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу Cat
        Cat cat = new Cat("Gray", 4.5f, 0.3f);
        Console.WriteLine(cat.ToString());
        Console.WriteLine("Cat sound: " + cat.MakeSound());

        // Створення об'єкта класу Dog
        Dog dog = new Dog("Brown", 12.0f, 0.5f);
        Console.WriteLine(dog.ToString());
        Console.WriteLine("Dog sound: " + dog.MakeSound());
    }
}