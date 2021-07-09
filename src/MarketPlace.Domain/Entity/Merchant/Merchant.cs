namespace MarketPlace.Domain.Entities
{
    public class Merchant : Entity
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }

        public static Merchant Create(string name, string document, string email, string phone, string password)
        {
            Merchant merchant = new Merchant()
            {
                Name = name,
                Document = document,
                Email = email,
                Phone = phone,
                Password = password,
                Role = "merchant"
            };
            return merchant;
        }
    }
}