namespace INTERFACES.Vehicles
{
    
public class Cycle : Vehicle
{
    int speed;
    int gear;
    public void applyBreaks(int decrement )
    {
        speed = speed - decrement;
    }

    public void changeGear(int newGear)
    {
        gear = newGear;
        
    }

    public void speedUp(int increment)
    {
        speed = speed+increment;
    }
}
}