using System.Collections;

namespace DesignPatterns.Behaviour.Iterator
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
