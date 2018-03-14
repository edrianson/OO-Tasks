using System;

namespace OO_Tasks_Interface {
    public interface IShapeProps {
        double GetArea();
        double GetPerimeter();
    }

    public interface ICircleProps {
        double GetArea();
        double GetCircumference();
    }

    public abstract class Shape {
        public string Name { get; set; }
        public string Colour { get; set; }

        public Shape(string name, string colour) {
            Name = name;
            Colour = colour;
        }
    }

    public abstract class Quadrilateral : Shape {
        public int NumSides { get; set; } = 4;

        public Quadrilateral(string name, string colour) : base(name, colour) { }
    }

    public class Square : Shape, IShapeProps {
        private double _sideLength;

        public Square(string name, string colour, double sideLength) : base(name, colour) {
            _sideLength = sideLength;
        }

        public double GetPerimeter() {
            return 4 * _sideLength;
        }

        public double GetArea() {
            return Math.Pow(_sideLength, 2);
        }
    }

    public class Rectangle : Shape, IShapeProps {
        private double _length, _width;

        public Rectangle(string name, string colour, double length, double width) : base(name, colour) {
            _length = length;
            _width = width;
        }

        public double GetPerimeter() {
            return 2 * (_length + _width);
        }

        public double GetArea() {
            return _length * _width;
        }
    }

    public class Circle : Shape, ICircleProps {
        public double Radius { get; set; }
        public const double PI = 3.142f;

        public Circle(string name, string colour, double radius) : base(name, colour) {
            Radius = radius;
        }

        // OO_Tasks.eap indicates for the absense of GetPerimeter() in the Circle class; Tests_Interface.cs omitted.

        public double GetArea() {
            return PI * Math.Pow(Radius, 2);
        }

        public double GetCircumference() {
            return 2 * PI * Radius;
        }
    }
}