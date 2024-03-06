namespace Task2;

public class Car : IMovable
{

    string _color;
    double _speed;
    string _model;
       public Car(string color,double speed,string model)
    {
        _color = color;
        _speed = speed;
        _model = model;
    }

    public string MoveLeft()
    {
        return $"Car Move Left";
    }

    public string MoveRight()
    {
    return $"Car Move Right"; 
       }
}
