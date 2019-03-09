using System;

namespace Shapes
{
    class Rectangle:Shape
    {
        public TypeOfShape type { get; } = TypeOfShape.Rectangle;

        private double _width;
        private double _height;

        public Rectangle(double w, double h)
        {
            this._width = w;
            this._height = h;
        }

        public override double Area()
        {
            return Math.Round(this._width * this._height,2);
        }
    }
}
