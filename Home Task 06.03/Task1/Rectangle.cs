namespace Task1;

public class Rectangle : Shape
{
    double _lenght;
    double _width;
    public Rectangle(double lenght,double width)
    {
        _lenght = lenght;
        _width = width;
    }
    public override double Calculate()
    {
        return _width * _lenght;
    }

    public override string PrintDescription()
    {
        return base.PrintDescription();
    }
}
