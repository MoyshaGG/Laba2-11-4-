using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{

    class TETriangle
    {
        static Random rnd = new Random();
        protected double side;

        public TETriangle()
        {
            side = rnd.Next(1, 100);
        }
        public TETriangle(double side)
        {
            this.side = side;
        }
        public TETriangle(TETriangle Triangle)
        {
            this.side = Triangle.side;
        }
        public override string ToString()
        {
            return  Convert.ToString(side);
        }



        public double Side
        {
            get { return side; }
            set { if (value > 0) side = value; }
        }
        public void GetSquare()
        {
            double square;
            square = (Math.Pow(side, 2) * Math.Sqrt(3)) / 4;
            Console.WriteLine($"Площа Трикутника: {square}");
        }
        public void Perimetr()
        {
            double perimside;
            perimside = side * 3;
            Console.WriteLine($"Периметр Трикутника: {perimside}");
        }

        public static void Compare(TETriangle Triangle, TETriangle Triangle2)
        {
            if (Triangle.side > Triangle2.side) { Console.WriteLine(Triangle.side + " > " + Triangle2.side + " рiзниця " + (Triangle.side - Triangle2.side)); }
            else if (Triangle.side < Triangle2.side) { Console.WriteLine(Triangle.side + " < " + Triangle2.side + " рiзниця " + (Triangle2.side - Triangle.side)); }
            else if (Triangle.side == Triangle2.side) { Console.WriteLine(Triangle.side + " = " + Triangle2.side);
            }


        }

        public static TETriangle operator +(TETriangle Triangle, TETriangle Triangle2)
        {
            TETriangle sum = new TETriangle();
            sum.side = Triangle.side + Triangle2.side;
            return sum;
        }
        public static TETriangle operator -(TETriangle Triangle, TETriangle Triangle2)
        {
            TETriangle sum = new TETriangle();
            sum.side = Math.Abs(Triangle.side - Triangle2.side);
            return sum;
        }
        public static TETriangle operator *(TETriangle Triangle, double n)
        {
            TETriangle sum = new TETriangle();
            sum.side = Triangle.side * n;
            return sum;
        }
        public static TETriangle operator *(double n, TETriangle Triangle)
        {
            TETriangle sum = new TETriangle();
            sum.side = n * Triangle.side;
            return sum;
        }
    }
}
