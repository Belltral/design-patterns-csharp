namespace DesignPatterns.Creational.Prototype.DeepCopy
{
    internal class Address : ICloneable
    {
        public string AddressName { get; set; }
        public int Number { get; set; }
        public string Postal { get; set; }

        public Address(string address, int number, string postal)
        {
            AddressName = address;
            Number = number;
            Postal = postal;
        }

        public object Clone()
        {
            return (Address)MemberwiseClone();
        }
    }
}
