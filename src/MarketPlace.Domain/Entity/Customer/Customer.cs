using CryptSharp;

namespace MarketPlace.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public static Customer Create(string name, string document, string email, string phone, string password)
        {
            Customer customer = new Customer()
            {
                Name = name,
                Document = document,
                Email = email,
                Phone = phone,
                Password = Crypter.MD5.Crypt(password),
                Role = "customer"
            };
            return customer;
        }

        public bool Login(string password)
        {
            return Crypter.CheckPassword(password, Password);
        }
    }
}