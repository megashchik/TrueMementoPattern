namespace TrueMemento
{
    public class Ordinator
    {
        string state = string.Empty;

        public Ordinator()
        {
            Change();
        }

        public void Change()
        {
            byte[] randomBytesState = new byte[50];
            new Random().NextBytes(randomBytesState);
            state = Convert.ToBase64String(randomBytesState);
        }

        public IMemento Save(string name)
        {
            return new Memento(state, name);
        }

        public void Load(IMemento memento)
        {
            if (memento is not Memento)
                throw new InvalidDataException("This memento was not taken in this class.");
            state = ((Memento)memento).State;
        }

        public override string ToString()
        {
            return state.ToString();
        }
    }
}