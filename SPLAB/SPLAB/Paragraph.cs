using System;

namespace SPLAB
{
    internal class Paragraph : Element
    {
        public string Text { get; set; }

        public Paragraph() { }
        public Paragraph(string text)
        {
            this.Text = text;
        }
        public override void Print() { Console.WriteLine(Text); }

        public override void Add(Element element)
        {
            //throw new NotImplementedException();
        }

        public override void Remove(Element element)
        {
           // throw new NotImplementedException();
        }

        public override Element Get(int index)
        {
            return this;
        }
    }
}
