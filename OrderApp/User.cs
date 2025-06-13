namespace OrderApp;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
}
