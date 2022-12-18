using InterfaceSegregationPrinciple.Lib;

namespace InterfaceSegregationPrinciple.ConsoleLib;

public static class ConsolePrint
{
    private static void Print(string message, double value, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{message} - {value}");
        Console.ResetColor();
    }

    public static void PrintPerimeter(IPerimeter figure)
    {
        Print("Периметр", figure.Perimeter(), ConsoleColor.Blue);
    }

    public static void PrintArea(IArea figure)
    {
        Print("Площадь", figure.Area(), ConsoleColor.Green);
    }
}
