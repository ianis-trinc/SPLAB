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
        private string _name;
        private string _surName;
        public string Name { get { return _name; } set { _name = value; } }
        public string SurName { get { return _surName; } set { _surName = value; } }
       
        public Author() { }
        public Author(string name) { this._name = name; }

       
        public void Print() { Console.Write(this._name); }
    }
}
