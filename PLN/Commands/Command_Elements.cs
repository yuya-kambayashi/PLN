using PLN.Drawables;
using PLN.Elements;
using PLN.Geometry;
using System.Data.Common;

namespace PLN.Commands
{
    public class DrawBeam : Command
    {
        public override string RegisteredName => "Elements.Beam";
        public override string Name => "Beam";

        public override async Task Apply(CADDocument doc, CancellationToken token, params string[] args)
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
                    Drawable nextBeam = new Beam(doc.ActiveView.Level, new Line(lastPt, p3.Value), 100, 100);
                    doc.Model.Add(nextBeam);

                    lastPt = p3.Value;
                }
                else if (p3.Result == ResultMode.Keyword && p3.Keyword == "Close")
                {
                    Drawable nextBeam = new Beam(doc.ActiveView.Level, new Line(lastPt, p1.Value), 100, 100);
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
        public override string RegisteredName => "Elements.Column";
        public override string Name => "Column";

        public override async Task Apply(CADDocument doc, CancellationToken token, params string[] args)
        {
            Editor ed = doc.Editor;
            ed.PickedSelection.Clear();

            while (true)
            {
                var p1 = await ed.GetPoint("Location: ");
                if (p1.Result != ResultMode.OK) return;

                if (p1.Result == ResultMode.OK)
                {
                    Column column = new Column(doc.ActiveView.Level, new PLN.Drawables.Point(p1.Value), 100);
                    doc.Model.Add(column);
                }
                else
                {
                    return;
                }
            }
        }
    }
    public class DrawRoom : Command
    {
        public override string RegisteredName => "Elements.Room";
        public override string Name => "Room";

        public override async Task Apply(CADDocument doc, CancellationToken token, params string[] args)
        {
            Editor ed = doc.Editor;
            ed.PickedSelection.Clear();

            var p1 = await ed.GetPoint("First point: ");
            if (p1.Result != ResultMode.OK) return;
            Point2D pt = p1.Value;
            Polyline consPoly = new Polyline(new Point2D[] { pt, pt });
            consPoly.Close();
            doc.Jigged.Add(consPoly);

            Point2DCollection points = new Point2DCollection();
            points.Add(pt);

            bool done = false;
            while (!done)
            {
                PointOptions options = new PointOptions("Next point: ", pt, (p) => consPoly.Points[consPoly.Points.Count - 1] = p);
                options.AddKeyword("End", true);
                var pNext = await ed.GetPoint(options);
                if (pNext.Result == ResultMode.OK)
                {
                    pt = pNext.Value;
                    consPoly.Points.Add(pt);
                    points.Add(pt);
                }
                else if (pNext.Result == ResultMode.Cancel)
                {
                    doc.Jigged.Remove(consPoly);
                    return;
                }
                else if (pNext.Result == ResultMode.Keyword)
                {
                    if (points.Count < 2)
                    {
                        doc.Jigged.Remove(consPoly);
                        return;
                    }

                    if (pNext.Keyword == "End")
                        done = true;
                }
            }

            doc.Jigged.Remove(consPoly);
            Room newItem = new Room(doc.ActiveView.Level, points, "Hoge");
            doc.Model.Add(newItem);
        }
    }
    public class DrawWall : Command
    {
        public override string RegisteredName => "Elements.Wall";
        public override string Name => "Wall";

        public override async Task Apply(CADDocument doc, CancellationToken token, params string[] args)
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
                    Wall nextWall = new Wall(doc.ActiveView.Level, new Line(lastPt, p3.Value));
                    doc.Model.Add(nextWall);

                    lastPt = p3.Value;
                }
                else if (p3.Result == ResultMode.Keyword && p3.Keyword == "Close")
                {
                    Wall nextWall = new Wall(doc.ActiveView.Level, new Line(lastPt, p1.Value));
                    doc.Model.Add(nextWall);

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
}
