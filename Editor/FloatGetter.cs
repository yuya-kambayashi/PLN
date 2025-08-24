using BaseCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace BaseCAD
{
    internal class FloatGetter : EditorGetter<FloatOptions, float>
    {
        protected override void AcceptCoordsInput(InputArgs<Point2D, float> args) =>
            args.InputValid = false;

        protected override void AcceptTextInput(InputArgs<string, float> args)
        {
            if (float.TryParse(args.Input, out args.Value))
            {
                if (!Options.AllowNegative && args.Value < 0)
                {
                    args.ErrorMessage = "*Negative numbers are not allowed*";
                    args.InputValid = false;
                }
                else if (!Options.AllowPositive && args.Value > 0)
                {
                    args.ErrorMessage = "*Positive numbers are not allowed*";
                    args.InputValid = false;
                }
                else if (!Options.AllowZero && args.Value == 0)
                {
                    args.ErrorMessage = "*Zero is not allowed*";
                    args.InputValid = false;
                }
            }
            else
            {
                args.InputValid = false;
            }
        }
    }
}
