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

