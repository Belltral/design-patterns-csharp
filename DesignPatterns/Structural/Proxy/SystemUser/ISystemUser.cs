
namespace DesignPatterns.Structural.Proxy.SystemUser
{
    public interface ISystemUser
    {
        public string FirstName { get; }
        public string UserName { get; }

        public List<SystemUserAddress> GetAddress();
    }
}
