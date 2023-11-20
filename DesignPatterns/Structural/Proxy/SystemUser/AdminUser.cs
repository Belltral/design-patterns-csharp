

namespace DesignPatterns.Structural.Proxy.SystemUser
{
    public class AdminUser : ISystemUser
    {
        private string _firstName { get; set; }
        private string _userName { get; set; }

        public string FirstName { get => _firstName; }
        public string UserName { get => _userName; }

        public AdminUser() { }

        public AdminUser(string firstName, string userName)
        {
            _firstName = firstName;
            _userName = userName;
        }


        public List<SystemUserAddress> GetAddress()
        {
            Thread.Sleep(2000);

            var users = new List<SystemUserAddress>
            {
                new SystemUserAddress { Street = "Av. Brasil", Number = 50 },
                new SystemUserAddress { Street = "Rua A", Number = 40 }
            };

            return users;
        }
    }
}
