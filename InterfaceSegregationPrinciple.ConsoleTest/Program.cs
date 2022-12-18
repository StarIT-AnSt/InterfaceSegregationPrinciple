using InterfaceSegregationPrinciple.ConsoleLib;
using InterfaceSegregationPrinciple.Lib;

Figure? figure;

Console.WriteLine("1. Квадрат");
Console.WriteLine("2. Круг");
var select = Console.ReadLine();
figure = select switch
{
    "1" => new Square(10),
    "2" => new Circle(10),
    _ => null
};

if (figure is not null)
{
    if (figure is IPerimeter f)
    {
        ConsolePrint.PrintPerimeter(f);
    }

    if (figure is IArea a)
    {
        ConsolePrint.PrintArea(a);
    }
}
