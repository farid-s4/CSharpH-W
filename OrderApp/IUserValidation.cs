namespace OrderApp;

public interface IUserValidation
{
    bool RegisterUser(string login, string password);
    User? LoginUser(string login, string password);
    
}