using GearOps.Domain.Enums.UserAccount;

namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Role : ValueObject
{
    public ERole Value { get; private set; } = ERole.User;

    public Role(int role)
    {
        EnumFlagException.ThrowIfFlagNotDefined<ERole>(role, "Nível de Acesso inválido.");
        Value = (ERole)role;
    }

    private Role() { }
}