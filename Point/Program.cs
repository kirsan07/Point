using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
--------------------------------------------
private
public
protected
----------
internal
protected internal
--------------------------------------------
 */

namespace Point
{
    class Point
    {
        //const - константа, которая обязательно должна быть проинициализирована непосредсвенно при объявлении.
        //		  const поля автоматически являются статическими.
        //readonly - нестатические поля только для чтения. Это константы, которые существют в обектах.
        public const int X_MAX = 1366;
        public const int Y_MAX = 768;
        double x;
        double y;
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            if (x > 1366) x = 1366;
            if (x < 0) x = 0;
            this.x = x;
        }
        public void SetY(double y)
        {
            if (y > 768) y = 768;
            if (y < 0) y = 0;
            this.y = y;
        }

        //				Properties
        public double X
        {
            get { return x; }
            set
            {
                if (value > X_MAX) value = X_MAX;
                if (value < 0) value = 0;
                x = value;
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                if (value > Y_MAX) value = Y_MAX;
                if (value < 0) value = 0;
                y = value;
            }
        }

        //				Constructors:
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine("Constructor:\t" + this.GetHashCode());
        }
        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
            Console.WriteLine("CopyConstructor:\t" + this.GetHashCode());
        }
        ~Point()
        {
            Console.WriteLine("Finalizer:\t" + this.GetHashCode());
        }
        //				Operators:
        public static Point operator +(Point A, Point B)
        {
            return new Point(A.X + B.X, A.Y + B.Y);
        }
        public static Point operator -(Point A, Point B)
            => new Point(A.X - B.X, A.Y - B.Y);
        public static Point operator ++(Point point)
        {
            point.x++;
            point.y++;
            return point;
        }
        //				Methods:
        public void Print()
        {
            Console.WriteLine($"X = {x},\tY = {y}");
        }
        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(point.x - x, 2) + Math.Pow(point.y - y, 2));
        }
    }
}

