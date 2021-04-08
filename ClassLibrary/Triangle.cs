using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    /// <summary>
    /// Flat figure representation - triangle
    /// </summary>
    public class Triangle
    {
        Point A, B, C;
        double AB, BC, AC;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="point1">A point</param>
        /// <param name="point2">B point</param>
        /// <param name="point3">C point</param>
        public Triangle (Point point1, Point point2, Point point3)
        {
            A = point1;
            B = point2;
            C = point3;

            AB = Math.Sqrt (Math.Pow (B.X - A.X, 2) + Math.Pow (B.Y - A.Y, 2));
            BC = Math.Sqrt (Math.Pow (C.X - B.X, 2) + Math.Pow (C.Y - B.Y, 2));
            AC = Math.Sqrt (Math.Pow (C.X - A.X, 2) + Math.Pow (C.Y - A.Y, 2));
        }

        public string Sides ()
        {
            return $"AB:{AB}\nBC:{BC}\nAC:{AC}";
        }

        public double Perimeter()
        {
            return AB + BC + AC;
        }

        public double Area()
        {
            double p = Perimeter () / 2.0;
            double h = (2*Math.Sqrt(p*(p-AC)*(p-AB)*(p-BC))) / AC;
            double s = (AC * h) / 2.0;
            return s;
        }

        public bool PointBelongs(Point point)
        {
            double first = (A.X - point.X) * (B.Y - A.Y) - (B.X - A.X) * A.Y - point.Y;
            double second = (B.X - point.X) * (C.Y - B.Y) - (C.X - B.X) * B.Y - point.Y;
            double third = (C.X - point.X) * (A.Y - C.Y) - (A.X - C.X) * C.Y - point.Y;

            if ((first >= 0 && second >= 0 && third >= 0) || (first <= 0 && second <= 0 && third <= 0))
            {
                return true;
            }

            return false;
        }

        public bool Validation()
        {
            if (AB + BC <= AC || AB+AC <= BC || AC + BC <= AB)
            {
                return false;
            }

            return true;
        }


    }
}
