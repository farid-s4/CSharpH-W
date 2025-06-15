using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace OrderApp;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.IO;

public class OrdersInit
{
    private List<Order> _orders;
    private readonly string _filePath;
    private readonly string _filePathXML;
    private readonly string _filePathBin;
    
    public OrdersInit() 
    {
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        string dataDir = Path.Combine(baseDir, "Data");
        _filePath = Path.Combine(dataDir, "orders.json");
        _filePathXML = Path.Combine(dataDir, "orders.xml");
        _filePathBin = Path.Combine(dataDir, "orders.bin");
        
        if (!Directory.Exists(dataDir))
        {
            Directory.CreateDirectory(dataDir);
        }

        _orders = LoadOrders() ?? new List<Order>();
    }
    
    public List<Order>? LoadOrders()
    {
        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath, "[]");
            return new List<Order>();
        }

        try
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Order>>(json);
        }
        catch
        {
            return new List<Order>();
        }
        
    }

    public void SaveOrders()
    {
        string json = JsonSerializer.Serialize(_orders);
        File.WriteAllText(_filePath, json);
    }

    public List<Order>? LoadOrdersXml()
    {
        if (!File.Exists(_filePath))
        {
            return new List<Order>();
        }

        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream stream = new FileStream(_filePath, FileMode.Open))
            {
                return (List<Order>)serializer.Deserialize(stream);
            }
        }
        catch (Exception ex)
        {
            return new List<Order>();
        }
    }

    public void SaveOrdersXml()
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (TextWriter writer = new StreamWriter(_filePath))
            {
                serializer.Serialize(writer, _orders);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    [Obsolete("bin dlya debilov")]
    public List<Order>? LoadOrdersBin()
    {
        if (!File.Exists(_filePathBin))
        {
            return new List<Order>();
        }

        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(_filePathBin, FileMode.Open))
            {
                return (List<Order>)formatter.Deserialize(stream);
            }
        }
        catch
        {
            return new List<Order>();
        }
    }

    [Obsolete("bin dlya debilov")]
    public void SaveOrdersBin()
    {
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(_filePathBin, FileMode.Create))
            {
                formatter.Serialize(stream, _orders);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public void CreateOrder(string name, string type, int price, Guid userId, int LoadAndSaveChoose)
    {
        Order o = new Order(name, type, price, userId);
        if (LoadAndSaveChoose == 1)
        {
            LoadOrders();
            _orders.Add(o);
            SaveOrders();
        }

        if (LoadAndSaveChoose == 2)
        {
            LoadOrdersXml();
            _orders.Add(o);
            SaveOrdersXml();
        }

        if (LoadAndSaveChoose == 3)
        {
            LoadOrdersBin();
            _orders.Add(o);
            SaveOrdersBin();
        }
    }

    public void DeleteOrder(Guid userId)
    {
        var jsonOrders = LoadOrders();
        var xmlOrders = LoadOrdersXml();
        var binOrders = LoadOrdersBin();
        
        jsonOrders.RemoveAll(o => o.UserId == userId);
        xmlOrders.RemoveAll(o => o.UserId == userId);
        binOrders.RemoveAll(o => o.UserId == userId);
        
        _orders = jsonOrders; SaveOrders();
        _orders = xmlOrders; SaveOrdersXml();
        _orders = binOrders; SaveOrdersBin();
    }
    
    public List<Order> GetOrders() => new List<Order>(_orders);
}