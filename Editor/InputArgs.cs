using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    internal class InputArgs<TInput, TValue>
    {
        public readonly TInput Input;
        public TValue Value;
        public string ErrorMessage;
        public bool InputValid;

        public InputArgs(TInput input)
        {
            Input = input;
            Value = default(TValue);
            InputValid = true;
            ErrorMessage = "*Invalid input*";
        }
    }
}
