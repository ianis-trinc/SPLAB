using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class Section : Element
    {
        protected string Title { get; set; }

        protected List<Element> Elements = new List<Element>();
        protected Section() { }
        public Section(string title) { this.Title = title; }

        public override void Add(Element element)
        {

            Elements.Add(element);
        }

        public override void Remove(Element element)
        {
            if (element is Section section)
            {
                Elements.Remove(section);
            }
            else
            {
                // Handle removing non-section elements if needed
            }
        }

        public override Element Get(int index)
        {
            if (index >= 0 && index < Elements.Count)
            {
                return Elements[index];
            }
            else
            {
                return null;
            }
        }

        public override void Print()
        {
            Console.WriteLine(Title);
            foreach(var element in Elements)
            {
                element.Print();
            }
        }
    }
}
