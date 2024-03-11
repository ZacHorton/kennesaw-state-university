using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2B
{
    abstract class GeometricObject
    {
        private double _side;

        public double Side
        {
            get
            {
                return this._side;
            }

            set
            {
                this._side = value;
            }
        }

        protected GeometricObject() { }

        protected GeometricObject(double side)
        {
            _side = side;
        }
    }

        class Octagon : GeometricObject, ICloneable, IComparable
    {
        private double _area;
        private double _perimeter;

        public Octagon()
        : base() { }

        public Octagon(double side)
            : base(side) { }

        public double getArea()
        {
            _area = (2 + 4 / Math.Sqrt(2)) * this.Side * this.Side;
            return Math.Round(_area, 2);
        }

        public double getPerimeter()
        {
            _perimeter = this.Side * 8;
            return Math.Round(_perimeter, 2);
        }

        public object Clone()
        {
            Octagon cloned = new Octagon();
            cloned.Side = this.Side;
            return cloned;
        }

        public int CompareTo(object obj)
        {
            Octagon x = (Octagon)obj;
            if (this.Side < x.Side) return -1;
            if (this.Side > x.Side) return 1;
            return 0;
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Octagon testProgram = new Octagon(8);
            Console.WriteLine("testProgram:");
            Console.WriteLine($"testProgram has a side of {testProgram.Side}.");
            Console.WriteLine($"testProgram has an area of {testProgram.getArea()}.");
            Console.WriteLine($"testProgram has a perimieter of {testProgram.getPerimeter()}.");

            Console.WriteLine();

            Octagon testClone = (Octagon)testProgram.Clone();
            Console.WriteLine("testClone:");
            Console.WriteLine($"testClone has a side of {testClone.Side}.");
            Console.WriteLine($"testClone has an area of {testClone.getArea()}.");
            Console.WriteLine($"testClone has a perimieter of {testClone.getPerimeter()}.");
            Console.WriteLine();

            int result = testProgram.CompareTo(testClone);
            if (result == 0)
            {
                Console.WriteLine("testProgram is equal to testClone.");
            }
            else
            {
                Console.WriteLine("testProgram is not equal to testClone.");
            }

            Console.ReadKey();
        }
    }
}
