using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    public class Editor
    {
        public HashSet<Drawable> Selection { get; private set; } = new HashSet<Drawable>();
        public Color SelectionHighlight { get; set; } = Color.FromArgb(64, 46, 116, 251);
    }
}
