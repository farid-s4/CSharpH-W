using System.Text.Json;

namespace OrderApp;

public class UserOrders{
    
    private List<Order> orders = new List<Order>();
    public void CreateOrder(string name , string item, int price)
    {
        Order o = new Order(name, item, price);
        o.UserId = UserValidation.LoginUserId;
        orders.Add(o);
    }

    public void ShowOrders()
    {
        
        foreach (var order in orders)
        {
            if (order.UserId == UserValidation.LoginUserId)
            {
                order.ShowOrder();
            }
        }
    }

    public void RecordToFile()
    {
        string relativeFolderPath = "data";
        string fileName = "ordersJson.json";
        
        if (!Directory.Exists(relativeFolderPath))
        {
            Directory.CreateDirectory(relativeFolderPath);
        }
        string fullPath = Path.Combine(relativeFolderPath, fileName);
        string jsonString = JsonSerializer.Serialize(orders);
        File.WriteAllText(fullPath, jsonString);
    }

    public void ReadToFile()
    {
        string relativeFolderPath = "data";
        string fileName = "ordersJson.json";
        
        if (!Directory.Exists(relativeFolderPath))
        {
            Directory.CreateDirectory(relativeFolderPath);
        }
        string fullPath = Path.Combine(relativeFolderPath, fileName);
        orders = JsonSerializer.Deserialize<List<Order>>(File.ReadAllText(fullPath));
        
    }
}