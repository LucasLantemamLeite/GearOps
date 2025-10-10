namespace GearOps.Migrations.Data.Mapping;

public sealed class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("Varchar(100)")
            .HasConversion(v => v.Value, v => new(v, "Nome do usuário é obrigatório."))
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnName("Email")
            .HasColumnType("varchar(255)")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Password)
            .HasColumnName("Password")
            .HasColumnType("varchar(255)")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Phone)
            .HasColumnName("Phone")
            .HasColumnType("varchar(20)")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Role)
            .HasColumnName("Role")
            .HasColumnType("smallint")
            .HasConversion(v => v.Value, v => new((int)v))
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasColumnName("CreatedAt")
            .HasColumnType("date")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
            .HasColumnName("UpdatedAt")
            .HasColumnType("date")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("boolean")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.CompanyId)
            .HasColumnName("CompanyId")
            .HasColumnType("uuid")
            .IsRequired();

        builder.HasOne<Company>()
            .WithMany()
            .HasForeignKey(x => x.CompanyId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}