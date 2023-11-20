namespace DesignPatterns.Structural.Proxy.SystemUser
{
    public class SystemUserAddress
    {
        public string Street { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"Street: {Street}, number {Number}";
        }
    }
}
