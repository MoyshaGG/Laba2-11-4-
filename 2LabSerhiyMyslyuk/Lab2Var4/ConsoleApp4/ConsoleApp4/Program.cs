using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            TETriangle Triangle = new TETriangle();
            TETriangle Triangle2 = new TETriangle();

            Triangle.GetSquare();
            Triangle.Perimetr();
            TETriangle.Compare(Triangle, Triangle2);

            Triangle2.GetSquare();
            Triangle2.Perimetr();
            TETriangle.Compare(Triangle2, Triangle);

            Console.WriteLine(" Сумма трикутникiв " + (Triangle + Triangle2));


        }
    }
}
