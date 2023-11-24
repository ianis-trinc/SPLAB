using System;

namespace SPLAB
{
    public class Author
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public Author() { }
        public Author(string name) { this.Name = name; }

       
        public void Print() { Console.Write(this.Name); }
    }
}
