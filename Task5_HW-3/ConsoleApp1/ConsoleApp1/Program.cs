using ConsoleApp1.books;
using ConsoleApp1.librarymembers;
using ConsoleApp1.LibraryOperations;

class Program
{
    static void Main(string[] args)
    {
        LibraryOperations members = new LibraryOperations();

        while (true)
        {
            Console.WriteLine("Choose what you want do in library: ");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Add member");
            Console.WriteLine("3. Remove book");
            Console.WriteLine("4. Remove member");
            Console.WriteLine("5. Check all members info");
            Console.WriteLine("6. Check all book names");
            Console.Write("Your choice: ");

            int choose = int.TryParse(Console.ReadLine(), out choose) ? choose : 0;

            switch (choose)
            {
                case 1:
                    {
                        Console.Write("Write book name: ");
                        string name = Console.ReadLine();

                        Console.Write("Write book description: ");
                        string description = Console.ReadLine();

                        Console.Write("Write book publisher: ");
                        string publisher = Console.ReadLine();

                        Console.Write("Write book author: ");
                        string author = Console.ReadLine();

                        Books book = new Books(name, description, author, publisher);
                        

                        members.addBook(book);
                        Console.WriteLine("Book added.");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Write member name: ");
                        string name = Console.ReadLine();

                        Console.Write("Write phone number: ");
                        int telnum = int.TryParse(Console.ReadLine(), out telnum) ? telnum : 0;

                        LibraryMembers member = new LibraryMembers(name, telnum);


                        members.addMembers(member);
                        Console.WriteLine("Member added.");
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter book name to remove: ");
                        string name = Console.ReadLine();
                        members.removeBook(name);
                        Console.WriteLine("Book removed");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Enter member name to remove: ");
                        string name = Console.ReadLine();
                        members.removeMembers(name);
                        Console.WriteLine("Member removed");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("All members:");
                        members.PrintMembersInfo();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("All books:");
                        members.printBookName();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice.");
                        break;
                    }
            }

            Console.WriteLine();
        }
    }
}
