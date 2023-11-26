using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class ImageContent
    {
        private string _imageContent;
        public ImageContent(string url)
        {
            _imageContent = $"imageContent fom {url}";
        }

        public ImageContent GetImageContent() { return this; }
    }
}
