using ConsoleApp1.books;
using ConsoleApp1.librarymembers;
using System;

namespace ConsoleApp1.LibraryOperations
{
    public class LibraryOperations
    {

        private List<Books> Books = new List<Books>();
        private List<LibraryMembers> libraryMembers = new List<LibraryMembers>();

        public void addBook(Books book)
        {
            Books.Add(book);
        }
        public void removeBook(string book_name) {
            Books.RemoveAll(book => book.Name == book_name);
        }

        public void PrintMembersInfo()
        {
            foreach (var members in libraryMembers)
            {
                members.PrintInfo();
            }
        }

        public void addMembers(LibraryMembers member)
        {
            libraryMembers.Add(member);
        }

        public void removeMembers(string memberName)
        {
            libraryMembers.RemoveAll(book => book.Name == memberName);
        }

        public void printBookName()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.Name);
            }
        }
    }

}
