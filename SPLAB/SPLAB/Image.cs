using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class Image
    {
        private string _url;
        private ImageContent _content;

        public Image(string url)
        {
            _url = url;
            _content = new ImageContent(_url);
        }

        public ImageContent content() { return _content.GetImageContent(); }
    }
}
