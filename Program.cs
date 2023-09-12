using System;

class Program
{
    static void Main()
    {
        double number = 4.5;

        // Округление до ближайшего целого числа
        int roundToNearest = (int)Math.Round(number);
        int ceiling = (int)Math.Ceiling(number);
        int floor = (int)Math.Floor(number);

        Console.WriteLine($"Значение аргумента: {number}");
        Console.WriteLine($"Округление до ближайшего целого: {roundToNearest}");
        Console.WriteLine($"Округление вверх: {ceiling}");
        Console.WriteLine($"Округление вниз: {floor}");

        number = -4.5;

        roundToNearest = (int)Math.Round(number);
        ceiling = (int)Math.Ceiling(number);
        floor = (int)Math.Floor(number);

        Console.WriteLine($"Значение аргумента: {number}");
        Console.WriteLine($"Округление до ближайшего целого: {roundToNearest}");
        Console.WriteLine($"Округление вверх: {ceiling}");
        Console.WriteLine($"Округление вниз: {floor}");
    }
}
