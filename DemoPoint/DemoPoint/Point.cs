using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPoint
{
    public class Point
    {
        // Constructor
        public Point(double x, double y)
        {
            Move(x, y);
        }

        // Default constructor = no arguments
        public Point()
        {}

        public void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()        // Getter for x
        {
            return x;
        }

        public double GetY()        // Getter for y
        {
            return y;
        }

        public void SetX(double x)      // Setter for x
        {
            this.x = x;
        }

        public void SetY(double y)      // Setter for y
        {
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        // Attributes
        private double x = 0;
        private double y = 0;
    }
}
