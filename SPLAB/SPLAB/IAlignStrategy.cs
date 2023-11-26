using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Vml.Office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal interface IAlignStrategy
    {
        void Render(Paragraph paragraph); // this function add "-" depending on algorithm: AlignRight, AlignLeft or AlignCenter.
    }
}
