namespace OrderApp;

public class Order
{
    public string? Name { get; set; }
    public DateTime Date { get; set; }
    public string? ItemType { get; set; }
    public int Price { get; set; }
    public Order(string name, string itemType, int price )
    {
        Name=name;
        Date=DateTime.Now;
        ItemType=itemType;
        Price=price;
    }
}