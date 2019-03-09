using System;

namespace Shapes
{
    //INHERITENCE inherits 'Shape' and builds upon it
    class Circle:Shape
    {
        public TypeOfShape type { get; } = TypeOfShape.Circle;

        private double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public override double Area()
        {
            return Math.Round((double)(Math.PI * Math.Pow(_radius,2)),2);
        }
    }
}
