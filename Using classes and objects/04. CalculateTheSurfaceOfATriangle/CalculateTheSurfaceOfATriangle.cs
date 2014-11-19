/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;

class CalculateTheSurfaceOfATriangle
{
    static double TriangleArea(double side, double height)
    {
        double area = 0;
        area = (side * height) / 2d;
        return area;
    }
    static double TriangleArea(double sideA, double sideB, double sideC)
    {
        double area = 0;
        double halfPerimeter = (sideA + sideB + sideC) / 2d;
        area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        return area;
        
    }
    static double TriangleAreaBySidesAndAngle(double sideA, double sideB, double angleAB)
    {
        double area = 0;
        double angle = angleAB * (Math.PI / 180);
        area = (sideA * sideB * Math.Sin(angle)) / 2d;
        return area;
    }
    static void Main()
    {
        double area = TriangleArea(24d, 30d, 18d);
        Console.WriteLine(area);
        area = TriangleArea(12d, 7d);
        Console.WriteLine(area);
        area = TriangleAreaBySidesAndAngle(31.6, 21.2, 37d);
        Console.WriteLine("{0:0.0}", area);
    }
}

