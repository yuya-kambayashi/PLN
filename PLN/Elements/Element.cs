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
    public enum LayoutType
    {
        Vertical,
        Horizontal,
    }

    internal abstract class Element : Drawable
    {
        public abstract LayoutType LayoutType { get; }
        public int ReferenceLevel { get; set; }
        public int UpperLevel { get; set; }

        public void updateLevel(int referenceLevel)
        {
            ReferenceLevel = referenceLevel;

            UpperLevel = (LayoutType == LayoutType.Vertical) ? referenceLevel + 1 : referenceLevel;
        }

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
