namespace OrderApp;

public class User
{
    public string? Login { get; set; }
    public string? Password { get; set; }
    public List<Order>? Orders { get; set; }

    public void CreateOrder(string name, string itemType, int price)
    {
        if (Orders != null)
        {
            foreach (var order in Orders)
            {
                order.CreateOrder(name, itemType, price);
            }
        }
    }
}