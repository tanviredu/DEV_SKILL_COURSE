using System;
namespace INTERFACES.Inter
{
    public interface IRegularPolygon
    {
        //public by default
        int NumberOfSides {get;set;}
        int SideLength {get;set;}

        double GetPerimeter();
        double GetArea();        
    }

}
  