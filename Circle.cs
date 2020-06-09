using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsTheDiameter
{
    class Circle
    {
        private double radius;
        // You can use Math.PI to get pi.

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return this.radius;
        }

        override public String ToString()
        {
            return this.radius.ToString();
        }

        // Need now getDiameter, getCircumference, getArea.

        public double getDiameter()
        {
            return this.radius * 2;
        }
        public double getCircumference()
        {
            return this.getDiameter() * Math.PI;
        }
        public double getArea()
        {
            return Math.Pow(Math.PI * this.getRadius(), 2);
        }

        // Neet also setRadius.
        public void setRadius(double newRadius)
        {
            this.radius = newRadius;
        }
    }
}
