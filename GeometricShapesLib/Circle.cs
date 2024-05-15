using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesLib
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area { get { return AreaCircle(); } }

        public Circle(double radius)
        {
            Radius = radius;
            Exist();
        }

        public override bool Exist()
        {
            if (Radius > 0)
            {
                return true;
            }
            throw new Exception("There is no such circle");
        }

        private double AreaCircle()
        {
            Exist();
            return Math.PI * Math.Pow(Radius, 2);

        }
    }
}
