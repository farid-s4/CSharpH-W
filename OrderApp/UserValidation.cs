namespace OrderApp;

public class UserValidation : IUserValidation
{
    public static Guid LoginUserId;
    public static string LoginUserName;
    private List<User> _users = new List<User>();

    public bool RegisterUser(string login, string password)
    {
        User u = new User(){Login = login, Password = password };
        foreach (var user in _users)
        {
            if (user.Login == login)
            {
                return false;
            }
        }
        _users.Add(u);
        return true;
    }

    public User? LoginUser(string login, string password)
    {
        foreach (var user in _users)
        {
            if (user.Login == login && user.Password == password)
            {
                LoginUserName = user.Login;
                LoginUserId = user.Id;
                return user;
            }
        }
        return null;
    }
    
}

