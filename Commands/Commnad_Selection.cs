using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD.Commands
{
    public class SelectionClear : Command
    {
        public override string RegisteredName => "Selection.Clear";
        public override string Name => "Clear Selection";

        public override Task Apply(CADDocument doc, params string[] args)
        {
            doc.Editor.CurrentSelection.Clear();
            return Task.FromResult(default(object));
        }
    }
}
