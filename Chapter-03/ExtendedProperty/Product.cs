namespace ExtendedProperty;

public class Product
{
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required Address Location { get; set; }
}

public class Address
{
    public required string State { get; set; }
    public required string Country { get; set; }
}
