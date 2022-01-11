using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueMemento
{
    public interface IMemento
    {
        DateTime DateTime { get; }
        string Name { get; }
    }
}
