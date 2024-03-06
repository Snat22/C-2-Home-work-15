namespace Task1;

public class Circle :Shape
{
    const double _pi = 3.14; 

    double _radius;

    public override double Calculate()
    {
        return _pi * _radius *_radius;
    }

    public override string PrintDescription()
    {
        return base.PrintDescription();
    }
}
