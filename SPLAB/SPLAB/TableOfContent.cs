using System;

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
