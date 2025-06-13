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
}