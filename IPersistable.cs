using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    public interface IPersistable
    {
        // Constructor(BinaryReader reader);
        void Save(BinaryWriter writer);
    }
}
