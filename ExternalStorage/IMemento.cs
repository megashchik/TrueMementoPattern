using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalStorage
{
    public interface IMemento
    {
        DateTime DateTime { get; }
        string Name { get; }
    }
}
