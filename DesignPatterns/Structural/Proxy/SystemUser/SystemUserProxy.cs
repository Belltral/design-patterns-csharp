

namespace DesignPatterns.Structural.Proxy.SystemUser
{
    public class SystemUserProxy : ISystemUser
    {
        private string _firstName { get; set; }
        private string _userName { get; set; }

        private ISystemUser? _realUser { get; set; }
        private List<SystemUserAddress>? _realUserAddresses { get; set; }

        public string FirstName { get => _firstName; }
        public string UserName { get => _userName; }

        public SystemUserProxy(string firstName, string userName)
        {
            _firstName = firstName;
            _userName = userName;
        }

        private ISystemUser CreateUser()
        {
            if (_realUser == null)
            {
                _realUser = new AdminUser(FirstName, UserName);
            }

            return _realUser;
        }

        public List<SystemUserAddress> GetAddress()
        {
            _realUser = CreateUser();

            if (_realUserAddresses == null)
            {
                _realUserAddresses = _realUser.GetAddress();
            }

            return _realUserAddresses;
        }
    }
}
