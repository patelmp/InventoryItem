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
            // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        }

        // Print item details
        public void PrintDetails()
        {
            // TODO: Print the details of the item (name, id, price, and stock quantity).
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
            // 2. Sell some items and then print the updated details.
            // 3. Restock an item and print the updated details.
            // 4. Check if an item is in stock and print a message accordingly.


        }
    }