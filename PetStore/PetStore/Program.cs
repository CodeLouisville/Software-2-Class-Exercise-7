using PetStore;
using PetStore.Logic;
using PetStore.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

var productLogic = new ProductLogic();

string userInput = DisplayMenuAndGetInput();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        var dogLeash = new DogLeash();

        Console.WriteLine("Creating a dog leash...");

        Console.Write("Enter the material the leash is made out of: ");
        dogLeash.Material = Console.ReadLine();

        Console.Write("Enter the length in inches: ");
        dogLeash.LengthInches = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the leash: ");
        dogLeash.Name = Console.ReadLine();

        Console.Write("Give the product a short description: ");
        dogLeash.Description = Console.ReadLine();

        Console.Write("Give the product a price: ");
        dogLeash.Price = decimal.Parse(Console.ReadLine());

        Console.Write("How many products do you have on hand? ");
        dogLeash.Quantity = int.Parse(Console.ReadLine());

        productLogic.AddProduct(dogLeash);
        Console.WriteLine("Added a dog leash");
    }
    if (userInput == "2")
    {
        Console.Write("What is the name of the dog leash you would like to view? ");
        var dogLeashName = Console.ReadLine();
        var dogLeash = productLogic.GetDogLeashByName(dogLeashName);
        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
        Console.WriteLine();
    }
    if (userInput == "3")
    {
        Console.WriteLine("The following products are in stock: ");
        var inStock = productLogic.GetOnlyInStockProducts();
        foreach (var item in inStock)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    if (userInput == "4")
    {
        Console.WriteLine($"The total price of inventory on hand is {productLogic.GetTotalPriceOfInventory()}");
        Console.WriteLine();
    }

    userInput = DisplayMenuAndGetInput();
}

static string DisplayMenuAndGetInput()
{
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Press 2 to view a Dog Leash Product");
    Console.WriteLine("Press 3 to view in stock products");
    Console.WriteLine("Press 4 to view the total price of current inventory");
    Console.WriteLine("Type 'exit' to quit");

    return Console.ReadLine();
}