using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class Table : Element
    {
        public string title;
        public Table() { }
        public Table(string title) { this.title = title; }

        public string GetTitle() { return title; }

        public override void Print() { Console.WriteLine($"Table title: {title}"); }
    }
}
