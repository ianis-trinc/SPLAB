using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal class Image : Element
    {
        private string imageName;
        public string ImageName { get { return imageName; } set { this.imageName = value; } }
        public Image() { } 
        public Image(string imageName)
        {
            this.imageName = imageName;
        }

       
        public override void Print() { Console.WriteLine(imageName); }


        public override void Add(Element element)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Element element)
        {
            throw new NotImplementedException();
        }

        public override Element Get(int index)
        {
            throw new NotImplementedException();
        }
    }
}
