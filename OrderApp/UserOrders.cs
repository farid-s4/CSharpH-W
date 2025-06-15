using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace OrderApp;

public class UserOrders
{
    private List<User> _usersOrders = new List<User>();
    private UserInit _userInit;
    private OrdersInit _ordersInit;
    
    public List<User> LoadOrdersForUser()
    {
        List<User> users = _userInit.LoadUsers() ?? new List<User>();
        List<Order> orders = _ordersInit.LoadOrders() ?? new List<Order>();
        
        foreach (var user in users)
        {

            user.Orders.Clear();
            
            foreach (var order in orders)
            {
                if (order.UserId == user.Id)
                {
                    user.Orders.Add(order);
                }
            }
        }
        return users;
    }
    

    public void AddUser(User user)
    {
        _usersOrders.Add(user);
    }

    public List<User> GetUsersWithOrders() => _usersOrders;
}