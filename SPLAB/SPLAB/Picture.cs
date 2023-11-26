using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLAB
{
    internal struct Dimension { public float height; public float width; }

    internal abstract class Picture
    {
        public abstract string url();
        public abstract Dimension dim();
        public abstract Image content();
    }
}
