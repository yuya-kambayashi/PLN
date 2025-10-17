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


            Column c2 = new Column(1, new Drawables.Point(new Point2D(sumX / site.Fig.Points.Count, sumY / site.Fig.Points.Count)), 200);
            ed.Document.Model.Add(c2);
        }
    }
}
