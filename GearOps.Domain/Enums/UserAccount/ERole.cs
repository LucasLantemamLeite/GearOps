namespace GearOps.Domain.Enums.UserAccount;

[Flags]
public enum ERole
{
    User = 1 << 0, //0001 -> 1
    Manager = User | 1 << 1, // 0011 -> 3
    Admin = User | Manager | 1 << 2, // 0111 -> 7
    Owner = User | Manager | Admin | 1 << 3 // 1111 -> 15
}