using System.Collections;

namespace DesignPatterns.Behaviour.Iterator
{
    public abstract class Iterator : IEnumerator
    {
        public abstract int Key();

        object IEnumerator.Current => Current();

        public abstract void Reset();

        public abstract bool MoveNext();

        public abstract object Current();
    }
}
