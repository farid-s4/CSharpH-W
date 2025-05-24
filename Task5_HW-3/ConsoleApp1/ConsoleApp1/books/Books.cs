namespace ConsoleApp1.books
{
    public class Books
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Books(string name, string description, string author, string publisher)
        {
            Name = name;
            Description = description;
            Author = author;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"{Name} by {Author}, published by {Publisher}. {Description}";
        }

    }

}


