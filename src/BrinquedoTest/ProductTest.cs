using BrinquedoDomain;

namespace BrinquedoTest;

public class ProductTest
{
    public class ToyStub : Toy
    {
        public ToyStub(int minAge, int maxAge) : base(minAge, maxAge)
        {
        }

        public override string GetToyName() => "ToyStub";
    }

    [Fact]
    public void ShouldCreateProductWithCorrectProperties()
    {
        // Arrange
        var id = Guid.NewGuid();
        var name = "Produto Teste";
        var valor = 99.99m;
        var toy = new ToyStub(2, 10);

        // Act
        var product = new Product<ToyStub>
        {
            Id = id,
            Name = name,
            Value = valor,
            Toy = toy
        };

        // Assert
        Assert.Equal(id, product.Id);
        Assert.Equal(name, product.Name);
        Assert.Equal(valor, product.Value);
        Assert.Equal(toy, product.Toy);
    }

    [Fact]
    public void ShouldReturnCorrectToyName()
    {
        // Arrange
        var toy = new ToyStub(2, 10);
        var product = new Product<ToyStub> { Toy = toy };

        // Act
        var toyName = product.Toy.GetToyName();

        // Assert
        Assert.Equal("ToyStub", toyName);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(100)]
    public void Value_SetValidValue_ShouldSetCorrectly(decimal v)
    {
        // Arrange
        var product = new Product<Toy> { Value = v };

        // Act
        decimal value = product.Value;

        // Assert
        Assert.Equal(v, value);
    }

    [Fact]
    public void Value_SetNegativeValue_ShouldThrowArgumentException()
    {
        // Arrange
        var product = new Product<Toy>();

        string expectedMessage = "Value must be greater than or equal to zero";

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => product.Value = -1);
        Assert.Equal(expectedMessage, ex.Message);
    }
}