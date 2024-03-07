namespace Task1;

public class Rectangle:Shape
{
    private double _width; 
    private double _length; 

    public Rectangle(double width, double lenght)
    {
    _length=lenght; 
    _width=width;
    }
    public override double CalculateArea()
    {
        return _width*_length;
    }
    public override void PrintDescription()
    {
         System.Console.WriteLine("It is rectangle");
    }
}