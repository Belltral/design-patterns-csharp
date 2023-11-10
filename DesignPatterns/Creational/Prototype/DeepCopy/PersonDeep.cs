using DesignPatterns.Creational.Prototype.Proto1;

namespace DesignPatterns.Creational.Prototype.DeepCopy
{
    internal class PersonDeep
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public PersonDeep() { }

        public PersonDeep(PersonDeep person, Address address)
        {
            Name = person.Name;
            Age = person.Age;
            Address = address;
        }

        public PersonDeep DeepCopy()
        {
            PersonDeep person = (PersonDeep)MemberwiseClone();
            person.Address = new Address(Address.AddressName, Address.Number, Address.Postal);

            return person;
        }
    }
}
