namespace OrderApp;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
    public List<Order> Orders { get; set; } = new List<Order>();

    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }

    public User() { }
}
