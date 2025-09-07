using PLN.Drawables;
using PLN.Elements;
using PLN.Geometry;

namespace PLN.Commands
{
    public class DrawBeam : Command
    {
        public override string RegisteredName => "Primitives.Beam";
        public override string Name => "Beam";

        public override async Task Apply(CADDocument doc, params string[] args)
        {
            Editor ed = doc.Editor;
            ed.PickedSelection.Clear();

            var p1 = await ed.GetPoint("First point: ");
            if (p1.Result != ResultMode.OK) return;
            Point2D lastPt = p1.Value;

            int i = 0;
            while (true)
            {
                var opts = new PointOptions("Next point: ", lastPt);
                if (i > 1)
                    opts.AddKeyword("Close");
                var p3 = await ed.GetPoint(opts);

                if (p3.Result == ResultMode.OK)
                {
                    Drawable nextBeam = new Beam(lastPt, p3.Value, 100, 100);
                    doc.Model.Add(nextBeam);

                    lastPt = p3.Value;
                }
                else if (p3.Result == ResultMode.Keyword && p3.Keyword == "Close")
                {
                    Drawable nextBeam = new Beam(lastPt, p1.Value, 100, 100);
                    doc.Model.Add(nextBeam);

                    lastPt = p3.Value;
                    return;
                }
                else
                {
                    return;
                }
                i++;
            }
        }
    }
    public class DrawColumn : Command
    {
        public override string RegisteredName => "Primitives.Column";
        public override string Name => "Column";

        public override async Task Apply(CADDocument doc, params string[] args)
        {
            Editor ed = doc.Editor;
            ed.PickedSelection.Clear();

            while (true)
            {
                var p1 = await ed.GetPoint("Location: ");
                if (p1.Result != ResultMode.OK) return;

                if (p1.Result == ResultMode.OK)
                {
                    Drawable point = new Column(p1.Value, 100);
                    doc.Model.Add(point);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
