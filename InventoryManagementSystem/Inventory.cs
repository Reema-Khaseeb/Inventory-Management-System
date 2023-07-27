﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ViewAllProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }

        public void EditProduct(string productName, string newName, double newPrice, int newQuantity)
        {
            var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (product != null)
            {
                product.Name = newName;
                product.Price = newPrice;
                product.Quantity = newQuantity;
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
