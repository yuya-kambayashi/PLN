using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    public interface IDict<TValue> : IEnumerable<TValue>
    {
        int Count { get; }
        TValue this[string key] { get; set; }

        void Add(string key, TValue value);
        void Clear();
        bool ContainsKey(string key);
        bool Remove(string key);
        bool TryGetValue(string key, out TValue value);
    }
}
