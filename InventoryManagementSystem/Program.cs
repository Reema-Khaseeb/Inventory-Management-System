using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            var inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\n--- Inventory Management System ---");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Edit a product");
                Console.WriteLine("4. Delete a product");
                Console.WriteLine("5. Search for a product");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter product name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter product price: ");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter product quantity: ");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            var newProduct = new Product(name, price, quantity);
                            inventory.AddProduct(newProduct);
                            Console.WriteLine("Product added successfully.");
                            break;

                        case 2:
                            inventory.ViewAllProducts();
                            break;

                        case 3:
                            Console.Write("Enter product name to edit: ");
                            string editName = Console.ReadLine();
                            Console.Write("Enter new product name: ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter new product price: ");
                            double newPrice = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter new product quantity: ");
                            int newQuantity = Convert.ToInt32(Console.ReadLine());

                            inventory.EditProduct(editName, newName, newPrice, newQuantity);
                            break;

                        case 4:
                            Console.Write("Enter product name to delete: ");
                            string deleteName = Console.ReadLine();
                            inventory.DeleteProduct(deleteName);
                            break;

                        case 5:
                            Console.Write("Enter product name to search: ");
                            string searchName = Console.ReadLine();
                            inventory.SearchProduct(searchName);
                            break;

                        case 6:
                            Console.WriteLine("Exiting...");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            }
        }
    }
}
