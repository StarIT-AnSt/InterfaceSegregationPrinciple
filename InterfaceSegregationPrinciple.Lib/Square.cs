namespace InterfaceSegregationPrinciple.Lib;

public class Square : Figure, IPerimeter, IArea
{
    private readonly double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double Perimeter()
    {
        return 4 * _side;
    }

    public double Area()
    {
        return _side * _side;
    }
}
