using System;
namespace INTERFACES.Abstract
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) : base(3, length)
        {
        }

        public override double GetArea()
        {
            //implemented the area method
            return SideLength*SideLength* Math.Sqrt(3)/4;
        }
    }

}
  