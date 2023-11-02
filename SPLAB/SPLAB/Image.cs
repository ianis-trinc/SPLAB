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
        public Image() { } 
        public Image(string imageName)
        {
            this.imageName = imageName;
        }

        public string GetImageName() { return imageName; }
        public override void Print() { Console.WriteLine("Print image"); }
    }
}
