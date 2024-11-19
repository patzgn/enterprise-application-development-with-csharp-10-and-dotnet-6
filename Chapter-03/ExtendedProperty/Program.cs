// See https://aka.ms/new-console-template for more information

using ExtendedProperty;

var product = new Product
{
    Name = "Men's Shirt",
    Price = 10.0m,
    Location = new Address
    {
        Country = "USA",
        State = "NY",
    },
};

// Accessing the extended properties
if (product is Product { Location: { Country: "USA" } })
{
    Console.WriteLine("USA");
}

// Accessing the extended properties with additional support
if (product is Product { Location.Country: "USA" })
{
    Console.WriteLine("USA");
}
