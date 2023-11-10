
namespace DesignPatterns.Creational.Prototype.Proto1
{
    internal class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person (Person pessoa)
        {
            Name = pessoa.Name;
            Age = pessoa.Age;
        }

        public object Clone()
        {
            return new Person(this);
        }
    }
}
