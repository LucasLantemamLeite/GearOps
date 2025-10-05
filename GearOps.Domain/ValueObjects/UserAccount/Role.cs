using GearOps.Domain.Enums.UserAccount;
using GearOps.Domain.ValueObjects.Base;

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