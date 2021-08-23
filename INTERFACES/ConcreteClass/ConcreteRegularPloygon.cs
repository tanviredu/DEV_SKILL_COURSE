using System;

namespace INTERFACES.Concrete
{
    public class ConcreteRegularPloygon{
        public int NumberOfSides {get;set;}
        public int SideLength {get;set;}

        public ConcreteRegularPloygon(int sides,int length)
        {
            NumberOfSides = sides;
            SideLength = length;
            
        }

        public double GetPerimeter(){
            return NumberOfSides*SideLength;
        }

        public virtual double GetArea(){
            throw new NotImplementedException();
        }


    }
}
  