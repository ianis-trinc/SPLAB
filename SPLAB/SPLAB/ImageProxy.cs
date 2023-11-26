using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class ImageProxy : Element
    {
        private string _url;
        private Image _realImage;
        public ImageProxy(string url) { _url = url; }

        public override void Add(Element element)
        {
            //throw new NotImplementedException();
        }

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

        public Image LoadImage()
        {
            if(_realImage == null)
            {
                _realImage = new Image(_url);
            }

            return _realImage;
        }

    }
}
