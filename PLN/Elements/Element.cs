using PLN.Drawables;
using PLN.Geometry;
using PLN.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLN.Elements
{
    internal class Element : Drawable
    {
        public override void Draw(Renderer renderer)
        {
            throw new NotImplementedException();
        }

        public override Extents2D GetExtents()
        {
            throw new NotImplementedException();
        }

        public override void TransformBy(Matrix2D transformation)
        {
            throw new NotImplementedException();
        }
    }
}
