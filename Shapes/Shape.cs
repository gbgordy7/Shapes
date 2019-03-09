using System.Drawing;

//general class that will be INHERITED by the Circle, Rectangle etc;  all shapes share
//some common items like Location but area is calculated differently for each shape; 

namespace Shapes
{
    //abstract class cannot be instantiated
    abstract class Shape
    {
        public enum TypeOfShape
        {
            Circle, Rectangle, etc
        }

        //ENCAPSULATION the variables of a class will be hidden from 
        //other classes, and can be accessed only through the methods 
        //of their current class; it is also known as data hiding

        //the variable _location is hidden and can only be changed
        //by calling SetLocation and accessed by calling X or Y

        private Point _location;

        //example of POLYMORPHISM through function overloading; same
        //function name but different parameters

        public void SetLocation(int X, int Y)
        {
            this._location = new Point(X, Y);
        }

        public void SetLocation(Point p)
        {
            this._location = p;
        }

        public int X()
        {
            return this._location.X;
        }

        public int Y()
        {
            return this._location.Y;
        }

        //ABSTRACTION
        //if you want a class to contain a particular method but you want the actual 
        //implementation of that method to be determined by child classes, you can 
        //declare the method in the parent class as an abstract

        //every shape has an area but that area is calculated differently for each 
        //shape therefore the implementation of area is handled by the child class

        //you must inherit this class and provide an Area method in the inherited class
        public abstract double Area();

        //POLYMORPHISM means having many forms; it is often expressed as 'one interface, multiple functions';
        //can be static or dynamic (as above); in this example Area has the same interface for each shape
        //but a different implementation which is defined in the derived class

    }
}
