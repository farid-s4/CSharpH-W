using System;


namespace ConsoleApp1.librarymembers
{
    public class LibraryMembers
    {

        public string Name { get; set; }
        public Guid GUID { get; init; }
        public int TelNum { get; set; }

        public LibraryMembers(string name, int telnum) {
            Name = name;
            TelNum = telnum;
            Guid GUID = Guid.NewGuid();
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} Telephone number:  {TelNum}");
        }
    }

}
