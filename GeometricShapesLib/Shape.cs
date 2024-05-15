using System.ComponentModel.DataAnnotations;

namespace GeometricShapesLib
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract bool Exist();
    }
}
