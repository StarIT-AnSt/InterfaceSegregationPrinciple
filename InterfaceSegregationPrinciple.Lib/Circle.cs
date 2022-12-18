namespace InterfaceSegregationPrinciple.Lib;

public class Circle : Figure, IArea
{
    private const double PI = 3.14;
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area()
    {
        return PI * _radius * _radius;
    }
}
