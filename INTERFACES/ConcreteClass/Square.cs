namespace INTERFACES.Concrete
{
    public class Square:ConcreteRegularPloygon{
        public Square(int length): base(4,length)
        {

                        
        }

        public override double GetArea()
        {
            return SideLength*SideLength;
        }

    }
}
  