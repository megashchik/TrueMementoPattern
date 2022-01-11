using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalStorage
{
    public class Caretaker
    {
        Stack<IMemento> snapshots = new Stack<IMemento> ();

        public void Save(IMemento memento)
        {
            snapshots.Push(memento);
        }

        public IMemento Undo()
        {
            return snapshots.Pop();
        }
    }
}
