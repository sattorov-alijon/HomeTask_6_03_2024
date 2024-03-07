namespace Task2;

public class Car:IMovable
{
private string _color; 
private string _model;
private double _speed; 
public Car(string color, string model, double speed)
{
  _color=color; 
  _model=model; 
  _speed=speed;  
} 
public string MoveLeft()
{
  return $"the car is moving left";
} 
public string MoveRight()
{
 return $"the car is moving right";
}
}