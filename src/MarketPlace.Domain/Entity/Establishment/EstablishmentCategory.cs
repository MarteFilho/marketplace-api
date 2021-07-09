using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class EstablishmentCategory : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Establishment> Market { get; private set; }

        public static EstablishmentCategory Create(string name, string description)
        {
            EstablishmentCategory establishmentCategory = new EstablishmentCategory()
            {
                Name = name,
                Description = description
            };
            return establishmentCategory;
        }
    }
}