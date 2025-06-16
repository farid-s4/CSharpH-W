namespace OrderApp {
    public class Order
    {
        public Guid UserId { get; set; } 
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ItemType { get; set; }
        public int Price { get; set; }
        
        public Order(string name, string itemType, int price, Guid userId )
        {
            Name=name;
            Date=DateTime.Now;
            ItemType=itemType;
            Price=price;
            UserId=userId;
        }
        public Order(){}
    }
}