using System;

class Triangle
{
    private double _base;
    private double _height;

    /*Konstruktor som tar bas och höjd som parametrar*/
    public Triangle(double baseLength, double height)
    {
        _base = baseLength;
        _height = height;
    }

    /*Metod för att räkna ut area av triangeln*/
    public double GetArea()
    {
        return (_base * _height) / 2;
    }
}
