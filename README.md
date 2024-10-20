namespace Circle.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapa två cirkelobjekt*/
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            /* Beräkna och skriv ut arean för båda cirklarna*/
            Console.WriteLine("Area av cirkel 1 (radie 5): " + string.Format("{0:0.0#}", circle1.GetArea()));
            Console.WriteLine("Area av cirkel 2 (radie 6): " + string.Format("{0:0.0#}", circle2.GetArea()));
            Console.WriteLine();

            /* Beräkna och skriv ut omkrets och volym för båda cirklarna*/
            Console.WriteLine("Omkrets av cirkel 1: " + string.Format("{0:0.0#}", circle1.GetCircumference()));
            Console.WriteLine("Volym av cirkel 1 (sfär): " + string.Format("{0:0.0#}", circle1.GetVolume()));
            Console.WriteLine();

            Console.WriteLine("Omkrets av cirkel 2: " + string.Format("{0:0.0#}", circle2.GetCircumference()));
            Console.WriteLine("Volym av cirkel 2 (sfär): " + string.Format("{0:0.0#}", circle2.GetVolume()));
            Console.WriteLine();

            /* Skapa ett triangelobjekt*/
            Triangle triangle = new Triangle(7, 21);

            /* Beräkna och skriv ut arean av triangeln*/
            Console.WriteLine("Area av triangel (bas 7, höjd 21): " + string.Format("{0:0.0#}", triangle.GetArea()));
            Console.WriteLine();
        }
    }

}
-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.cs
{
    internal class Circle
    {
       
        private int _radius;

        /* Konstruktor som tar radien som parameter*/
        public Circle(int radius)
        {
            _radius = radius;
        }

        /* Metod för att räkna ut arean på cirkeln*/
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

        /* Metod för att räkna ut omkretsen på cirkeln*/
        public double GetCircumference()
        {
            return 2 * Math.PI * _radius;
        }

        /* Metod för att räkna ut volymen om det vore en sfär*/
        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }
    }

}
------------------------------------------------------------------------------------------------
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
