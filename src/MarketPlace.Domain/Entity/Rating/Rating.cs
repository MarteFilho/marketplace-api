using System;

namespace MarketPlace.Domain.Entities
{
    public class Rating : Entity
    {
        public int Note { get; private set; }
        public string Comments { get; private set; }
        public Guid EstablishmentId { get; private set; }
        public Establishment Establishment { get; private set; }
    }
}