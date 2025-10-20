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
            //Editor ed = doc.Editor;

            //var beams = ed.Document.Model.OfType<Beam>().ToList();

            //foreach (var beam in beams)
            //{
            //    Column c1 = new Column(beam.ReferenceLevel - 1, new Drawables.Point(beam.Fig.StartPoint), 200);
            //    ed.Document.Model.Add(c1);

            //    Column c2 = new Column(beam.ReferenceLevel - 1, new Drawables.Point(beam.Fig.EndPoint), 200);
            //    ed.Document.Model.Add(c2);
            //}

            Editor ed = doc.Editor;

            var cnt = ed.Document.Model.OfType<Hatch>().Count();

            if (cnt != 2)
            {
                throw new Exception("Only two Rectangle is allowed.");
            }

            var rect1 = ed.Document.Model.OfType<Hatch>().ElementAt(0);
            var rect2 = ed.Document.Model.OfType<Hatch>().ElementAt(1);

            Path64 subject = new() { };
            foreach (var pt in rect1.Points)
            {
                subject.Add(new Point64((long)(pt.X), (long)(pt.Y)));
            }


            // Polygon2
            Path64 clip = new() { };
            foreach (var pt in rect2.Points)
            {
                clip.Add(new Point64((long)(pt.X), (long)(pt.Y)));
            }

            // 演算オブジェクト作成
            Clipper64 clipper = new();
            clipper.AddSubject(subject);
            clipper.AddClip(clip);

            // 結果格納先
            Paths64 solution = new();

            // 共通部分（交差）
            clipper.Execute(ClipType.Intersection, FillRule.NonZero, solution);

            Console.WriteLine("=== Intersection ===");
            foreach (var p in solution)
            {
                foreach (var pt in p)
                    Console.WriteLine($"{pt.X}, {pt.Y}");
                Console.WriteLine("---");
            }

            // 差集合（subject から clip を切り取る）
            solution.Clear();
            clipper.Execute(ClipType.Difference, FillRule.NonZero, solution);

            Console.WriteLine("=== Difference ===");
            foreach (var s in solution)
            {
                var pts = new Point2DCollection();

                foreach (var pt in s)
                {
                    Console.WriteLine($"{pt.X}, {pt.Y}");

                    pts.Add(new Point2D(pt.X, pt.Y));

                }
                var polygon = new Hatch(pts);
                ed.Document.Model.Add(polygon);
                Console.WriteLine("---");
            }
            ed.Document.Model.Remove(rect1);
            ed.Document.Model.Remove(rect2);
        }
    }
}
