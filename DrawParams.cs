using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    public class DrawParams
    {
        public Graphics Graphics { get; private set; }
        public bool ScaleLineWeights { get; private set; }
        public float ZoomFactor { get; private set; }

        public DrawParams(Graphics graphics, bool scaleLineWeights, float zoomFactor)
        {
            Graphics = graphics;
            ScaleLineWeights = scaleLineWeights;
            ZoomFactor = zoomFactor;
        }

        public float GetScaledLineWeight(float lineWeight)
        {
            if (ScaleLineWeights)
                return lineWeight;
            else
                return ViewToModel(lineWeight);
        }

        public float ModelToView(float dim)
        {
            return dim / ZoomFactor;
        }

        public float ViewToModel(float dim)
        {
            return dim * ZoomFactor;
        }
    }
}
