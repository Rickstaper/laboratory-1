using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="radius"></param>
        public Circle(Point point, double radius)
        {
            Center = point;
            Radius = radius;
        }

        public override string ToString ()
        {
            return $"Area:{this.Area()}\nPerimeter:{this.Perimeter()}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return Math.PI * Math.Pow (Radius, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool Validation(Point point)
        {
            // Distance between center and target point
            double x = Math.Sqrt (Math.Pow (point.X - Center.X, 2) + Math.Pow (point.Y - Center.Y, 2));

            if (x > Radius)
                return false;

            return true;
        }
    }
}
