namespace BrinquedoDomain;

public abstract class Toy
{
    public int MinAge { get; set; }
    public int MaxAge { get; set; }

    public Toy(int minAge, int maxAge)
    {
        MinAge = minAge;
        MaxAge = maxAge;
    }

    public bool RecommendedAge(int age)
    {
        return age >= MinAge && age <= MaxAge;
    }

    public abstract string GetToyName();
}
