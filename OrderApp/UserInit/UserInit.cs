namespace OrderApp;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.IO;

public class UserInit 
{
    private List<User> _users = new List<User>();
    private readonly string _filePath;

    public UserInit()
    {
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        string dataDir = Path.Combine(baseDir, "Data");
        _filePath = Path.Combine(dataDir, "_users.json");

        if (!Directory.Exists(dataDir))
        {
            Directory.CreateDirectory(dataDir);
        }

        _users = LoadUsers() ?? new List<User>();
    }
    
    public List<User>? LoadUsers()
    {
        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath, "[]");
            return new List<User>();
        }

        try
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<User>>(json);
        }
        catch
        {
            return new List<User>();
        }
    }

    public void SaveUsers()
    {
        string json = JsonSerializer.Serialize(_users);
        File.WriteAllText(_filePath, json);
    }

    public bool CreateUser(string login, string password)
    {
        User user = new User(login, password);
        LoadUsers();
        foreach (var u in _users)
        {
            if (u.Login == login)
            {
                return false;
            }
        }
        _users.Add(user);
        SaveUsers();
        return true;
    }

    public void DeleteUser(string login, string password)
    {
        LoadUsers();
        foreach (var u in _users)
        {
            if (u.Login == login && u.Password == password)
            {
                _users.Remove(u);
            }
        }
        SaveUsers();
    }

    public User? LoginUser(string login, string password)
    {
        foreach (var u in _users)
        {
            if (u.Login == login && u.Password == password)
            {
                return u;
            }
        }
        return null;
    }
    
    public List<User> GetUsers() => new List<User>(_users);
    
}
    


