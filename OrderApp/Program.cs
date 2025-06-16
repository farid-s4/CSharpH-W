using OrderApp;
using System;

var userInit = new UserInit();
var orderInit = new OrdersInit();
var userOrders = new UserOrders();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");
    
    var choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
            Register();
            break;
        case "2":
            Login();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            Console.ReadKey();
            break;
    }
}

void Register()
{
    Console.Clear();
    Console.WriteLine("=== Registration ===");
    Console.Write("Enter username: ");
    var login = Console.ReadLine();
    Console.Write("Enter password (min 8 characters, no spaces): ");
    var password = Console.ReadLine();

    if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
    {
        Console.WriteLine("Username and password cannot be empty.");
        Console.ReadKey();
        return;
    }

    if (userInit.CreateUser(login, password))
    {
        Console.WriteLine("Registration successful!");
    }
    else
    {
        Console.WriteLine("Registration failed. Username may be taken or password doesn't meet requirements.");
    }
    Console.ReadKey();
}

void Login()
{
    Console.Clear();
    Console.WriteLine("=== Login ===");
    Console.Write("Enter username: ");
    var login = Console.ReadLine();
    Console.Write("Enter password: ");
    var password = Console.ReadLine();

    var user = userInit.LoginUser(login, password);
    if (user != null)
    {
        Console.WriteLine($"Login successful! Welcome, {user.Login}");
        UserMenu(user);
    }
    else
    {
        Console.WriteLine("Invalid username or password.");
        Console.ReadKey();
    }
}

void UserMenu(User user)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"=== User Menu: {user.Login} ===");
        Console.WriteLine("1. Create Order");
        Console.WriteLine("2. View My Orders");
        Console.WriteLine("3. Logout");
        Console.Write("Select an option: ");

        var choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                CreateOrder(user);
                break;
            case "2":
                ViewOrdersMenu(user.Id);
                break;
            case "3":
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadKey();
                break;
        }
    }
}

void CreateOrder(User user)
{
    Console.Clear();
    Console.WriteLine("=== Create Order ===");
    Console.Write("Enter order name: ");
    var name = Console.ReadLine();
    Console.Write("Enter order type: ");
    var type = Console.ReadLine();
    Console.Write("Enter price: ");
    
    if (!int.TryParse(Console.ReadLine(), out var price))
    {
        Console.WriteLine("Invalid price format.");
        Console.ReadKey();
        return;
    }
    
    Console.WriteLine("\nSelect save format:");
    Console.WriteLine("1. JSON (default)");
    Console.WriteLine("2. XML");
    Console.WriteLine("3. Binary");
    Console.Write("Your choice (1-3): ");
    
    if (!int.TryParse(Console.ReadLine(), out var formatChoice) || formatChoice < 1 || formatChoice > 3)
    {
        formatChoice = 1; 
    }

    orderInit.CreateOrder(name, type, price, user.Id, formatChoice);
    Console.WriteLine($"Order created successfully");
    Console.ReadKey();
}


void ViewOrdersMenu(Guid userId)
{
    Console.Clear();
    Console.WriteLine("=== Choose order storage format ===");
    Console.WriteLine("1 - JSON (default format)");
    Console.WriteLine("2 - XML (human-readable alternative)");
    Console.WriteLine("3 - BIN (binary format)");

    Console.Write("Enter the number of your choice: ");
    string? input = Console.ReadLine();

    int storageType;
    if (!int.TryParse(input, out storageType) || storageType < 1 || storageType > 3)
    {
        Console.WriteLine("Invalid input. Press any key to return to the menu.");
        Console.ReadKey();
        return;
    }

    ViewOrders(userId, storageType);
}


void ViewOrders(Guid userId, int storageType)
{
    Console.Clear();
    Console.WriteLine("=== Your Orders ===");

    List<Order>? orders = storageType switch
    {
        1 => orderInit.GetOrdersJson(),
        2 => orderInit.GetOrdersXml(),
        3 =>  orderInit.GetOrdersBin(),
        _ => new List<Order>()
    };
    
    var userOrders = orders.Where(o => o.UserId == userId).ToList();

    if (userOrders.Count == 0)
    {
        Console.WriteLine("You have no orders.");
    }
    else
    {
        foreach (var order in userOrders)
        {
            Console.WriteLine($"Name: {order.Name}");
            Console.WriteLine($"Type: {order.ItemType}");
            Console.WriteLine($"Price: {order.Price}");
            Console.WriteLine($"Date: {order.Date}");
            Console.WriteLine("-------------------");
        }
    }

    Console.ReadKey();
}

