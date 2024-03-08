//Defined namespace for better understanding of programmer

namespace InventorySystem
{
    //Define Public class name as InventoryItem

    public class InventoryItem
    {
        // Predefined program properties
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        // Initialized the properties with the values passed to the constructor
        public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
        {
            ItemName = itemName;
            ItemId = itemId;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        // Defining multiple public Methods
        // Update the price of the item
        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
            Console.WriteLine($"Price of {ItemName} updated to {Price:C}");
        }

        // Restock the item
        public void RestockItem(int additionalQuantity)
        {
            QuantityInStock += additionalQuantity;
            Console.WriteLine($"{additionalQuantity} {ItemName}(s) added to stock. Total quantity: {QuantityInStock}");
        }

        // Sell an item
        public void SellItem(int quantitySold)
        {
            if (quantitySold <= QuantityInStock)
            {
                QuantityInStock -= quantitySold;
                Console.WriteLine($"{quantitySold} {ItemName}(s) sold. Remaining stock: {QuantityInStock}");
            }
            else
            {
                Console.WriteLine($"Insufficient stock of {ItemName} to sell {quantitySold}. Available stock: {QuantityInStock}");
            }
        }

        // Check if an item is in stock
        public bool IsInStock()
        {
            if (QuantityInStock > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Print item details
        public void PrintDetails()
        {
            Console.WriteLine($"ItemName: {ItemName}, ID: {ItemId}, Price: {Price:C}, Stock Quantity: {QuantityInStock}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of InventoryItemDetails
            InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
            InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

            // Printing initial details
            Console.WriteLine("Initial Item Details:");
            item1.PrintDetails();
            item2.PrintDetails();
            Console.WriteLine();

            // Updating the price of item1
            Console.WriteLine("Updating the price of item1:");
            item1.UpdatePrice(1500.00);
            Console.WriteLine();

            // Selling some items
            Console.WriteLine("Selling Items:");
            item1.SellItem(3);
            item2.SellItem(27); // Trying to sell more than in stock
            Console.WriteLine();

            // Restocking an item
            Console.WriteLine("Restocking Items:");
            item2.RestockItem(15);// Making available of Item2 which is required as per sell order.
            Console.WriteLine();

            // Checking if an item is in stock
            Console.WriteLine("Checking Stock availability :");
            Console.WriteLine($"Is Laptop in stock? {item1.IsInStock()}");
            Console.WriteLine($"Is Smartphone in stock? {item2.IsInStock()}");

            // Added empty WriteLine statement to make space between Checking Stock availability and Final Item Details
            Console.WriteLine();

            // Printing final details of stock availability 
            Console.WriteLine("Final Item Details:");
            item1.PrintDetails();
            item2.PrintDetails();
        }
    }
}