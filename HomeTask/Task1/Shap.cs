﻿namespace Task1;

public abstract class Shape
{
   
    public abstract double CalculateArea(); 
    public virtual void PrintDescription()
    { 
       System.Console.WriteLine("Something about shape");
    } 
}