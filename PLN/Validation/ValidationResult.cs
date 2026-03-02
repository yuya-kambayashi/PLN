using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLN.Validation
{
    internal class ValidationResult
    {
        public string Name { get; }
        public bool IsSuccess { get; }
        public string Message { get; private set; }

        public ValidationResult(string name, bool isSuccess, string message)
        {
            Name = name;
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
