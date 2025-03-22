using System;

namespace BrinquedoDomain;

public class Product<T> where T : Toy
{
    private decimal value;

    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Value
    {
        get => value;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Value must be greater than or equal to zero");
            }
            this.value = value;
        }
    }
    public T Toy { get; set; }
}
