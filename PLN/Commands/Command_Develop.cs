using Clipper2Lib;
using PLN.Drawables;
using PLN.Elements;
using PLN.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PLN.Commands
{
    public class Develop1 : Command
    {
        public override string RegisteredName => "Develop.Develop1";
        public override string Name => "Develop Develop1";

        public override async Task Apply(CADDocument doc, params string[] args)
        {
            Editor ed = doc.Editor;

            var beams = ed.Document.Model.OfType<Beam>().ToList();

            foreach (var beam in beams)
            {
                Column c1 = new Column(beam.ReferenceLevel - 1, new Drawables.Point(beam.Fig.StartPoint), 200);
                ed.Document.Model.Add(c1);

                Column c2 = new Column(beam.ReferenceLevel - 1, new Drawables.Point(beam.Fig.EndPoint), 200);
                ed.Document.Model.Add(c2);
            }
        }
    }
    public class Develop2 : Command
    {
        public override string RegisteredName => "Develop.Develop2";
        public override string Name => "Develop Develop2";

        public override async Task Apply(CADDocument doc, params string[] args)
        {
            Editor ed = doc.Editor;

            var cnt = ed.Document.Model.OfType<Site>().Count();

            if (cnt == 0)
            {
                throw new Exception("Input one site.");
            }

            if (cnt > 1)
            {
                throw new Exception("Only one site is allowed.");
            }

            var site = ed.Document.Model.OfType<Site>().First();


            var sumX = site.Fig.Points.Sum(pt => pt.X);
            var sumY = site.Fig.Points.Sum(pt => pt.Y);


            var ptCenter = new Point2D(sumX / site.Fig.Points.Count, sumY / site.Fig.Points.Count);


            var pts = new Point2DCollection();
            foreach (var ptBase in site.Fig.Points)
            {
                var ptNew = ptBase.MoveTowards(ptCenter, 100);
                pts.Add(ptNew);
            }
            var polygon = new Polygon(pts);
            ed.Document.Model.Add(polygon);
        }
    }
    public class Develop3 : Command
    {
        public override string RegisteredName => "Develop.Develop3";
        public override string Name => "Develop Develop3";

        public override async Task Apply(CADDocument doc, params string[] args)
        {

            Editor ed = doc.Editor;

            var cnt = ed.Document.Model.OfType<Hatch>().Count();

            if (cnt != 2)
            {
                throw new Exception("Only two Rectangle is allowed.");
            }

            var rect1 = ed.Document.Model.OfType<Hatch>().ElementAt(0);
            var rect2 = ed.Document.Model.OfType<Hatch>().ElementAt(1);

            PathD subject = new PathD();
            foreach (var pt in rect1.Points)
            {
                subject.Add(new PointD(pt.X, (double)pt.Y));
            }
            PathsD subjects = new PathsD();
            subjects.Add(subject);

            PathD clip = new PathD();
            foreach (var pt in rect2.Points)
            {
                clip.Add(new PointD(pt.X, pt.Y));
            }
            PathsD clips = new PathsD();
            clips.Add(clip);

            PathsD intersection = Clipper.Intersect(subjects, clips, FillRule.NonZero);
            PathsD difference = Clipper.Difference(subjects, clips, FillRule.NonZero);
            PathsD union = Clipper.Union(subjects, clips, FillRule.NonZero);

            Console.WriteLine("=== Difference ===");
            foreach (var s in union)
            {
                var pts = new Point2DCollection();

                foreach (var pt in s)
                {

                    pts.Add(new Point2D((float)pt.x, (float)pt.y));

                }
                var polygon = new Hatch(pts);
                ed.Document.Model.Add(polygon);
            }
            ed.Document.Model.Remove(rect1);
            ed.Document.Model.Remove(rect2);
        }
    }
    public class Develop4 : Command
    {
        public override string RegisteredName => "Develop.Develop4";
        public override string Name => "Develop Develop4";

        public override async Task Apply(CADDocument doc, params string[] args)
        {

            Editor ed = doc.Editor;

            var cnth = ed.Document.Model.OfType<Hatch>().Count();

            if (cnth != 1)
            {
                throw new Exception("Only one Rectangle is allowed.");
            }

            var cntl = ed.Document.Model.OfType<Line>().Count();

            if (cntl != 1)
            {
                throw new Exception("Only one Rectangle is allowed.");
            }

            var rect1 = ed.Document.Model.OfType<Hatch>().ElementAt(0);

            var line1 = ed.Document.Model.OfType<Line>().ElementAt(0);

            PathD subject = new PathD();
            foreach (var pt in rect1.Points)
            {
                subject.Add(new PointD(pt.X, (double)pt.Y));
            }
            PathsD subjects = new PathsD();
            subjects.Add(subject);

            PathD clip = new PathD();
            clip.Add(new PointD(line1.StartPoint.X, line1.StartPoint.Y));
            clip.Add(new PointD(line1.EndPoint.X, line1.EndPoint.Y));

            PathsD clips = new PathsD();
            clips.Add(clip);

            PathsD intersection = Clipper.Intersect(subjects, clips, FillRule.NonZero);
            PathsD difference = Clipper.Difference(subjects, clips, FillRule.NonZero);
            PathsD union = Clipper.Union(subjects, clips, FillRule.NonZero);

            Console.WriteLine("=== Difference ===");
            foreach (var d in difference)
            {
                var pts = new Point2DCollection();

                foreach (var pt in d)
                {

                    pts.Add(new Point2D((float)pt.x, (float)pt.y));

                }
                var polygon = new Hatch(pts);
                ed.Document.Model.Add(polygon);
            }
            ed.Document.Model.Remove(rect1);
            ed.Document.Model.Remove(line1);

        }
    }
    public class Develop5 : Command
    {
        public override string RegisteredName => "Develop.Develop5";
        public override string Name => "Develop Develop5";

        public override async Task Apply(CADDocument doc, params string[] args)
        {


            Editor ed = doc.Editor;

            var cnt = ed.Document.Model.OfType<Hatch>().Count();

            if (cnt != 2)
            {
                throw new Exception("Only two Rectangle is allowed.");
            }



            var rect1 = ed.Document.Model.OfType<Hatch>().ElementAt(0);
            var rect2 = ed.Document.Model.OfType<Hatch>().ElementAt(1);

            PathD subject = new PathD();
            foreach (var pt in rect1.Points)
            {
                subject.Add(new PointD(pt.X, (double)pt.Y));
            }
            PathsD subjects = new PathsD();
            subjects.Add(subject);

            PathD clip = new PathD();
            foreach (var pt in rect2.Points)
            {
                clip.Add(new PointD(pt.X, pt.Y));
            }
            PathsD clips = new PathsD();
            clips.Add(clip);

            PathsD intersection = Clipper.Intersect(subjects, clips, FillRule.NonZero);
            PathsD difference = Clipper.Difference(subjects, clips, FillRule.NonZero);
            PathsD union = Clipper.Union(subjects, clips, FillRule.NonZero);

            string s = "";
            if (intersection.Count == 0 && union.Count == 1)
            {
                s = "隣接";
            }
            else if (intersection.Count > 0 && union.Count == 1)
            {
                s = "重複";
            }
            else
            {
                s = "重複なし";
            }

            var ts = ed.Document.Model.OfType<Drawables.Text>().ToList();
            foreach (var tt in ts)
            {
                ed.Document.Model.Remove(tt);
            }

            Text t = new Drawables.Text(Point2D.Zero, s, 100);
            ed.Document.Model.Add(t);


        }
    }
}