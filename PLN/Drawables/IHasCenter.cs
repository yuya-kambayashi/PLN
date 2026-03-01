using PLN.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLN.Drawables
{
    internal interface IHasCenter
    {
        Point2D Center { get; }
    }
}
