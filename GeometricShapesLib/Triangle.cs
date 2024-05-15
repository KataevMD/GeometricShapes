using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesLib
{
    public class Triangle : Shape
    {
        public double LengthSideA { get; set; }
        public double LengthSideB { get; set; }
        public double LengthSideC { get; set; }
        public bool IsRectangular
        {
            get
            {
                double squareSideA = SquareSide(LengthSideA);
                double squareSideB = SquareSide(LengthSideB);
                double squareSideC = SquareSide(LengthSideC);

                if ((squareSideA + squareSideB == squareSideC) || (squareSideA + squareSideC == squareSideB) || (squareSideC + squareSideB == squareSideA))
                    return true;
                else
                    return false;
            }
        }

        public override double Area { get { return AreaTriangle(); } }

        public Triangle(double a, double b, double c)
        {
  
            LengthSideA = a;
            LengthSideB = b;
            LengthSideC = c;
            Exist();
        }

        private static double SquareSide(double side)
        {
            return side * side;
        }

        private double AreaTriangle()
        {
            double halfMeter = HalfMeterTriangle();
            return Math.Sqrt(halfMeter * (halfMeter - LengthSideA) * (halfMeter - LengthSideB) * (halfMeter - LengthSideC));
        }

        private double HalfMeterTriangle()
        {
            return (LengthSideA + LengthSideB + LengthSideC) / 2;
        }


        public override bool Exist()
        {
            if ((LengthSideA + LengthSideB > LengthSideC) && (LengthSideA + LengthSideC > LengthSideB)
                && (LengthSideC + LengthSideB > LengthSideA) && ((LengthSideA > 0) && (LengthSideB > 0) && (LengthSideC > 0)))
            {
                return true;
            }
            throw new Exception("There is no such triangle");
        }
    }
}
