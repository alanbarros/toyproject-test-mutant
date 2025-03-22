namespace BrinquedoDomain;

public class Car : Toy
{
    public Car(int minAge, int maxAge) :
        base(minAge, maxAge)
    {
    }

    public override string GetToyName()
    {
        return "Car";
    }
}
