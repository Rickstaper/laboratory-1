using System;

namespace lab1
{
    class Program
    {
        static Point CreatePoint()
        {
            Console.Write ("Enter x and y with space\nAnswer:");
            string[] coordinates = Console.ReadLine ().Split();
            double x = Convert.ToDouble (coordinates[0]);
            double y = Convert.ToDouble (coordinates[1]);
            Point point = new Point (x, y);

            return point;
        }
        static void Main (string[] args)
        {
            int selector;
            bool isExit = false;
            do
            {
                Console.Write ("0) Exit\n1) Create circle\n2) Create Tringle\nAnswer:");
                selector = Convert.ToInt32 (Console.ReadLine());
                switch(selector)
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        Point point = CreatePoint ();
                        Console.Write ("Enter radius:");
                        double radius = Convert.ToDouble (Console.ReadLine ());
                        Circle circle = new Circle (point, radius);
                        Console.WriteLine (circle);
                        break;
                    case 2:
                        Console.WriteLine ("Enter three point");
                        Point A = CreatePoint ();
                        Point B = CreatePoint ();
                        Point C = CreatePoint ();
                        Triangle triangle = new Triangle (A, B, C);
                        if (triangle.Validation())
                        {
                            Console.WriteLine (triangle);
                        }
                        break;
                    default:
                        Console.WriteLine ("Error!");
                        break;
                }
            }
            while (!isExit);
        }
    }
}
