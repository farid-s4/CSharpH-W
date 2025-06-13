using OrderApp;
 
UserValidation users = new UserValidation();

Console.WriteLine("Login");
string login = Console.ReadLine();
Console.WriteLine("Password");
string password = Console.ReadLine();

users.RegisterUser(login, password);

Console.WriteLine("Sign");

users.LoginUser(login, password);

UserOrders orders = new UserOrders();
Console.WriteLine("Order name");
string name = Console.ReadLine();
Console.WriteLine("Order description");
string description = Console.ReadLine();
Console.WriteLine("Order Price");
int price = int.Parse(Console.ReadLine());
orders.CreateOrder(name, description, price);

orders.ShowOrders();