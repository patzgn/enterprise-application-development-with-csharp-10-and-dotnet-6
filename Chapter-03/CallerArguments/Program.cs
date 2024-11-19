// See https://aka.ms/new-console-template for more information

using CallerArguments;

Console.WriteLine("Hello, World!");

var gift = new Gift();
// (gift is null).IsTrue();

Product? product = null;

//The following call to AddToCart will throw an error as the product passed in is null
// The validation is done by the Helper class ArgumentValidation
AddToCart(product, 1);

static void AddToCart(Product? product, uint quantity)
{
    ArgumentValidation.ThrowIfNull(product);
    // Implementation to add the product to cart
}
