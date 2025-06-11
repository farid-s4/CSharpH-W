namespace OrderApp;

public class UserValidation : User
{
    private List<User> _users = new List<User>();

    public void CreateUser(string login, string password)
    {
        User u = new User(){Login = login, Password = password };
        _users.Add(u);
    }
}