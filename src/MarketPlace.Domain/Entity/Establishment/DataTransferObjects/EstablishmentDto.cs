using System;

namespace MarketPlace.Domain.Entities
{
    public class EstablishmentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string FU { get; set; }
        public double Distance { get; set; }

        public static EstablishmentDto Build(Establishment establishment, double latitude, double longitude)
        {
            if (establishment == null)
                return null;

            return new EstablishmentDto()
            {
                Id = establishment.Id,
                Name = establishment.Name,
                Address = establishment.Address,
                Neighborhood = establishment.Neighborhood,
                City = establishment.City,
                FU = establishment.FU,
                Distance = establishment.CalculateDistance(latitude, longitude)
            };
        }
    }
}