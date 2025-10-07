using PLN.Drawables;
using PLN.Elements;
using PLN.Geometry;
using System;
using System.Collections.Generic;
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

            var beams = ed.Document.Model.OfType<Beam>();
            int cnt = beams.Count();

            List<Drawable> columns = new List<Drawable>();

            foreach (var beam in beams)
            {
                Column c1 = new Column(beam.ReferenceLevel - 1, new Drawables.Point(beam.Fig.StartPoint), 200);
                columns.Add(c1);

                Column c2 = new Column(beam.ReferenceLevel - 1, new Drawables.Point(beam.Fig.EndPoint), 200);
                columns.Add(c2);
            }

            ed.Document.Model.AddAll(columns);
        }
    }
}
