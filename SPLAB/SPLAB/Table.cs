using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class Table : Element
    {
        public string Title { get; set; }
        public Table() { }
        public Table(string title) { this.Title = title; }

        public override void Add(Element element)
        {
            throw new NotImplementedException();
        }

        public override Element Get(int index)
        {
            throw new NotImplementedException();
        }

        public string GetTitle() { return Title; }

        public override void Print() { Console.WriteLine($"Table title: {Title}"); }

        public override void Remove(Element element)
        {
            throw new NotImplementedException();
        }
    }
}
