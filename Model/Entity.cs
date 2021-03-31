using System;

namespace Model
{
    public abstract class Entity
    {
       public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public override bool Equals(object obj)
        {
            var entity = obj as Entity;
            if (ReferenceEquals(this, entity))
                return true;
            if (ReferenceEquals(null, entity))
                return false;

            return Id.Equals(entity.Id);
        }
        public static bool operator ==(Entity entity,Entity entity1) 
        {
            if (ReferenceEquals(entity, null) && ReferenceEquals(entity1, null))
                return true;
            if (ReferenceEquals(entity, null) || ReferenceEquals(entity1, null))
                return false;

            return entity.Equals(entity1);
        }       
        public static bool operator !=(Entity entity,Entity entity1) 
        {
            return !(entity == entity1);
        }
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 917) + Id.GetHashCode(); 
        }
        public override string ToString()
        {
            return $"{GetType().Name} : [Id={Id}]";
        }
    }
}
