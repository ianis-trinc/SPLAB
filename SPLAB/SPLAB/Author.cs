using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
