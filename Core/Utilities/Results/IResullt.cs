using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResullt
    {
        bool Success { get; }
        string Message { get; }
    }
}