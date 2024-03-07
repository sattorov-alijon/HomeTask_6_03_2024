using System.Net.NetworkInformation;

namespace Task1;

public class Circle:Shape
{
private double _radius; 
 const double Pi=3.14; 

 public Circle(double radius)
 {
    _radius=radius;
 }
    public override double CalculateArea()
    {
         return Pi*_radius*_radius;
    }
    public override void PrintDescription()
    {
        System.Console.WriteLine("It is circle");
    }
}