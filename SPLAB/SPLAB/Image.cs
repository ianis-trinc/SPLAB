using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class Image : Element
    {
        private string _url;
        private ImageContent _content;

        public Image(string url)
        {
            _url = url;
            Thread.Sleep(1000);
            _content = new ImageContent(_url);
        }

        public override void Add(Element element)
        {
           // throw new NotImplementedException();
        }

        public ImageContent content() { return _content.GetImageContent(); }

        public override Element Get(int index)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine(_url);
        }

        public override void Remove(Element element)
        {
            throw new NotImplementedException();
        }
    }
}
