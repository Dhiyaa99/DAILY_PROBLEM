using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal CostPrice { get; set; }

    public Product(string name, decimal price, int quantity, decimal costPrice = 0)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Price = Price;
    }
}

class InventoryManagementSystem
{
    static Dictionary<string, Product> products = new Dictionary<string, Product>();
    static int totalSales = 0;
    static decimal totalRevenue = 0;

    static void Main()
    {
        if (!AuthenticateUser()) return;

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add a new product");
            Console.WriteLine("2. Update product quantity");
            Console.WriteLine("3. Display product list");
            Console.WriteLine("4. Record sale");
            Console.WriteLine("5. Generate product report");
            Console.WriteLine("6. Generate sales report");
            Console.WriteLine("7. Exit");
            Console.Write("Select an operation (1-7): ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddProduct(); 
                    break;
                case "2":
                    UpdateQuantity(); 
                    break;
                case "3":
                    Display(); 
                    break;
                case "4":
                    RecordSale(); 
                    break;
                case "5":
                    ProductReport(); 
                    break;
                case "6":
                    SalesReport(); 
                    break;
                case "7":
                    running = false; 
                    Console.WriteLine("Thank you for using the Inventory Management System!"); 
                    break;
                default: 
                    Console.WriteLine("Invalid choice. Please select a valid operation."); 
                    break;
            }
        }
    }

    static bool AuthenticateUser()
    {
        Console.WriteLine("Welcome to the Inventory Management System!");
        Console.Write("Please enter your username: ");
        string username = Console.ReadLine();
        Console.Write("Please enter your password: ");
        string password = Console.ReadLine();

        if (username == "admin" && password == "adminpass")
        {
            Console.WriteLine($"Authentication successful! Welcome, {username}!");
            return true;
        }
        else
        {
            Console.WriteLine("Authentication failed. Access denied.");
            return false;
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        if (products.ContainsKey(name))
        {
            Console.WriteLine("Product already exists.");
            return;
        }

        Console.Write("Enter product price: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.WriteLine("Invalid price.");
            return;
        }

        Console.Write("Enter initial quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        Console.Write("Enter cost price (optional, default 0): ");
        string costInput = Console.ReadLine();
        decimal costPrice = 0;
        decimal.TryParse(costInput, out costPrice);

        products[name] = new Product(name, price, quantity, costPrice);
        Console.WriteLine("Product added successfully!");
    }

    static void UpdateQuantity()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        if (!products.ContainsKey(name))
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write("Enter new quantity: ");
        if (int.TryParse(Console.ReadLine(), out int quantity))
        {
            products[name].Quantity = quantity;
            Console.WriteLine("Quantity updated successfully!");
        }
        else
        {
            Console.WriteLine("Invalid quantity.");
        }
    }

    static void Display()
    {
        Console.WriteLine("Product List:");
        foreach (var product in products.Values)
        {
            Console.WriteLine($"- {product.Name} - Price: ${product.Price}, Quantity: {product.Quantity}");
        }
    }

    static void RecordSale()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        if (!products.ContainsKey(name))
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write("Enter quantity sold: ");
        if (!int.TryParse(Console.ReadLine(), out int soldQty))
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        if (products[name].Quantity < soldQty)
        {
            Console.WriteLine("Not enough stock available.");
            return;
        }

        products[name].Quantity -= soldQty;
        totalSales += soldQty;
        totalRevenue += soldQty * products[name].Price;
        Console.WriteLine("Sale recorded successfully!");
    }

    static void ProductReport()
    {
        Console.WriteLine("Product Report:");
        foreach (var product in products.Values)
        {
            Console.WriteLine($"{product.Name}: {product.Quantity} in stock");
        }
    }

    static void SalesReport()
    {
        Console.WriteLine("Sales Report:");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Total Revenue: ${totalRevenue}");
    }
}
