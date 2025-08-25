using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    public interface IPersistable
    {
        void Load(DocumentReader reader);
        void Save(DocumentWriter writer);
    }
}
