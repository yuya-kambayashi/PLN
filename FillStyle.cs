using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    [TypeConverter(typeof(FillStyleConverter))]
    public partial struct FillStyle
    {
        public enum FillType
        {
            None = 0,
            Solid = 1,
            Hatch = 2
        }

        public FillType Type { get; set; }
        public Color Color { get; set; }
        public Color FillColor { get; set; }
        public HatchStyle HatchStyle { get; set; }

        public FillStyle(Color color)
            : this()
        {
            Type = FillType.Solid;
            Color = color;
            FillColor = Color.Transparent;
            HatchStyle = HatchStyle.Percent50;
        }

        public FillStyle(Color color, Color fillColor, HatchStyle hatchStyle)
            : this()
        {
            Type = FillType.Hatch;
            Color = color;
            FillColor = fillColor;
            HatchStyle = hatchStyle;
        }

        public Brush CreateBrush(DrawParams param)
        {
            if(param.SelectionMode)
                return new SolidBrush(param.SelectionColor);
            else if (Type == FillType.Solid)
                return new SolidBrush(Color);
            else if (Type == FillType.Hatch)
                return new HatchBrush(HatchStyle, Color, FillColor);

            return new SolidBrush(Color.Transparent);
        }
    }
}
