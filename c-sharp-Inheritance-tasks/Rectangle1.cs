using System;


namespace c_sharp_Inheritance_tasks
{
    /*
   Task 2:
Create a base class called Shape with the following properties:
string Color: Represents the color of the shape.
double Area: Represents the area of the shape.
Create a derived class called Rectangle that inherits from the
Shape class. Add the following additional properties to the Rectangle class:
double Width: Represents the width of the rectangle.
double Height: Represents the height of the rectangle.
Implement the logic in the Area property of the Rectangle class 
to calculate and return the area of the rectangle(width* height).
Create constructors for both classes to initialize the properties.
Ensure that the constructors of the derived class call the constructor
of the base class to initialize the inherited properties.
   */
    internal class Rectangle1 : Shape
    {
        double Width;
        double Height;

        public Rectangle1() { }

        public Rectangle1(string color, double Area, double width, double height) : base(color, Area)
        {
            Width = width;
            Height = height;
            Area = calcArea(Width, Height);


            Console.WriteLine("The Area of the rectangle is: " + Area);
        }
        public Rectangle1(double width, double height):base()
        {
            Width = width;
            Height = height;
           double Area=calcArea(Width, Height);


            Console.WriteLine("The Area of the rectangle is: " + Area);
        }


    }
}
