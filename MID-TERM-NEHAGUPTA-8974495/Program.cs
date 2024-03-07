using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)  // TODO: Initialize the properties with the values passed to the constructor.
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;   
        QuantityInStock = quantityInStock; 
                                               
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {

        Price = newPrice;  // TODO: Update the item's price with the new price.
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
        // TODO: Increase the item's stock quantity by the additional quantity.
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {

        if (quantitySold > QuantityInStock)
        {
            Console.WriteLine($" Oops! Not enough stock to sell {quantitySold} items of {ItemName}.");
        }
        else
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"Sold {quantitySold} items of {ItemName}.");
        }


    }

    // Check if an item is in stock
    public bool IsInStock() 

    { return QuantityInStock > 0; }  // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
   
    // Print item details 
    public void PrintDetails() // TODO: Print the details of the item (name, id, price, and stock quantity).
    { Console.WriteLine($" itemname: {ItemName}");
      Console.WriteLine($" itemID: {ItemId}");
      Console.WriteLine($" price: ${Price:F2}");
      Console.WriteLine($" quantityInStock: {QuantityInStock}");

    }
   
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);     

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine(" \n Details of items: ");
        item1.PrintDetails();
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.
        Console.WriteLine(" \n 10 Smartphones got sold");
        item2.SellItem(10);
        Console.WriteLine("\n Item's details updated");
        item2.PrintDetails();

        Console.WriteLine("\n 11 Laptops to be sold");
        item1.SellItem(11);
        Console.WriteLine("\n Item's details updated");
        item1.PrintDetails();

        // 3. Restock an item and print the updated details.
       
        Console.WriteLine("\n Restocking 2 Laptops for updating the inventroy");
        item1.RestockItem(2);
        Console.WriteLine("Updated Item1 Details:");
        item1.PrintDetails();

        Console.WriteLine("\n Restocking 5 Smartphones for updating the inventroy");
        item2.RestockItem(5);
        Console.WriteLine("Updated Item2 Details:");
        item2.PrintDetails();


        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($"\n Check Whether {item1.ItemName} in stock? {item1.IsInStock()}");
        if (item1.IsInStock())
        {
            Console.WriteLine("Perfect! Laptop is in stock and available.");
        }
        else
        {
            Console.WriteLine("Oops! Laptop is not in stock and unavialable.");
        }


        Console.WriteLine($"\n Check Wether {item2.ItemName} in stock? {item1.IsInStock()}");
        if (item2.IsInStock())
        {
            Console.WriteLine("Yes,Perfect! Smartphone is in stock and available.");
        }
        else
        {
            Console.WriteLine("Oops! Smartphone is not in stock and unavialable.");
        }
    }
}

