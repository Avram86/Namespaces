//type alias
using Point2D = Namespaces.Graphics2D.Point;
//namespace alias
using point3D= Namespaces.Graphics3D;
using System;



namespace Namespaces.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //aliasarea namespaceului

            Point2D p2D = new Point2D();
            p2D.X = 100;
            p2D.Y = 200;

            point3D::Point p3D = new point3D::Point();
            p3D.X = 100;
            p3D.Y = 200;
            p3D.Z = 300;

            global::Point p = new global::Point();
            p.Label = "Test";
        }
    }
}
