using System;

namespace MarketPlace.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public bool Active { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
        public void Activate()
        {
            Active = true;
        }
    }
}