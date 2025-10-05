using GearOps.Domain.Enums.UserAccount;

namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Role : ValueObject
{
    public ERole Value { get; private set; } = ERole.User;

    public Role(int role)
    {
        Value = (ERole)role;
    }

    private Role() { }
}