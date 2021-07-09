using System;
using System.Collections.Generic;
using GeoCoordinatePortable;

namespace MarketPlace.Domain.Entities
{
    public class Establishment : Entity
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string FU { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public List<Product> Products { get; private set; }
        public List<Rating> Rating { get; private set; }
        public Guid EstablishmentCategoryId { get; private set; }
        public EstablishmentCategory EstablishmentCategory { get; private set; }

        public static Establishment Create(string name, string address, string neighborhood, string city, string fu, double latitude, double longitude)
        {
            Establishment market = new Establishment()
            {
                Name = name,
                Address = address,
                Neighborhood = neighborhood,
                City = city,
                FU = fu,
                Latitude = latitude,
                Longitude = longitude
            };
            return market;
        }

        public double CalculateDistance(double latitude, double longitude)
        {
            GeoCoordinate establishment = new GeoCoordinate(Latitude, Longitude);
            GeoCoordinate customerLocation = new GeoCoordinate(latitude, longitude);
            return customerLocation.GetDistanceTo(establishment);
        }

        public void AddCategory(Guid establishmentCategoryId)
        {
            EstablishmentCategoryId = establishmentCategoryId;
        }
    }
}