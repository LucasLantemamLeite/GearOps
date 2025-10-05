namespace GearOps.Domain.Entities.Base;

public abstract class Entity
{
    protected Guid Id { get; set; }

    protected Entity(Guid id) => Id = id;

    protected Entity() => Id = Guid.NewGuid();
}