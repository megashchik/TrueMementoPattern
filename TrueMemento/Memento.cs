using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueMemento
{
    internal class Memento : IMemento
    {
        public DateTime DateTime { get; private set; }

        public string Name { get; private set; }


        internal string State { get; private set; }

        public Memento(string state, string name)
        {
            State = state;
            DateTime = DateTime.Now;
            Name = name;
        }
    }
}
