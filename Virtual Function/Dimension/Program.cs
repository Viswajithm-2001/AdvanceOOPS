using System;
namespace Dimension;

class Program
{
    public static void Main(string[] args)
    {
        //create one object for Rectangle
        Rectangle rectangle = new Rectangle(20,10.3);
        //create one object for sphere
        Sphere sphere = new Sphere(21);

        //Display areas of both
        rectangle.Display();
        sphere.Display();
    }
}