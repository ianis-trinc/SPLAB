using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class TableOfContent : Element
    {
        public string BookTitle { get; set; }

        public override void Add(Element element)
        {
            throw new NotImplementedException();
        }

        public override Element Get(int index)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        { 
            Console.WriteLine("Table Of Content"); 
        }

        public override void Remove(Element element)
        {
            throw new NotImplementedException();
        }
    }
}
