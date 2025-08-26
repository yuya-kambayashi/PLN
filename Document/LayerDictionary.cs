using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer = BaseCAD.Graphics.Layer;

namespace BaseCAD
{
    public class LayerDictionary : PersistableDictionaryWithDefault<Layer>
    {
        public LayerDictionary() : base("0", Layer.Default)
        {
            ;
        }
    }
}
