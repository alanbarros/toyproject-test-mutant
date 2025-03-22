using BrinquedoDomain;

namespace BrinquedoTest;

public class CarTest
{
    [Theory]
    [InlineData(2, 2, 10)]
    [InlineData(4, 2, 10)]
    [InlineData(10, 2, 10)]
    public void ShouldReturnTrueWhenAgeIsRecomendade(int age, int minAge, int maxAge)
    {
        var result = new Car(minAge, maxAge)
            .RecommendedAge(age);

        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 2, 10)]
    [InlineData(11, 2, 10)]
    [InlineData(15, 2, 10)]
    public void ShouldReturnFalseWhenAgeIsNotRecomendade(int age, int minAge, int maxAge)
    {
        var result = new Car(minAge, maxAge)
            .RecommendedAge(age);

        Assert.False(result);
    }

    [Fact]
    public void ShouldReturnCarWhenGetToyName()
    {
        var result = new Car(2, 10)
            .GetToyName();

        Assert.Equal("Car", result);
    }
}