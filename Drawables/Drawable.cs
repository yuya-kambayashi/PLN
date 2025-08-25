using BaseCAD.Drawables;
using BaseCAD.Geometry;
using BaseCAD.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Color = BaseCAD.Graphics.Color;

namespace BaseCAD.Drawables
{
    [Serializable]
    public abstract class Drawable : INotifyPropertyChanged, IPersistable
    {
        public Style Style { get; set; } = new Style(Color.White);
        public bool Visible { get; set; } = true;

        public event PropertyChangedEventHandler PropertyChanged;

        public abstract void Draw(Renderer renderer);
        public abstract Extents2D GetExtents();
        public virtual bool Contains(Point2D pt, float pickBoxSize) { return GetExtents().Contains(pt); }
        public abstract void TransformBy(Matrix2D transformation);
        public virtual ControlPoint[] GetControlPoints() { return new ControlPoint[0]; }
        public virtual void TransformControlPoint(int index, Matrix2D transformation) { }

        public virtual Drawable Clone() { return (Drawable)MemberwiseClone(); }
        protected Drawable()
        {
            ;
        }
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Drawable(BinaryReader reader)
        {
            Style = new Style(reader);
            Visible = reader.ReadBoolean();
        }
        public virtual void Save(BinaryWriter writer)
        {
            Style.Save(writer);
            writer.Write(Visible);
        }
    }
}
