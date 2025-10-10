namespace GearOps.Migrations.Data.Mapping;

public sealed class CompanyMap : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Companies");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(100)")
            .HasConversion(v => v.Value, v => new(v, "Nome da empresa é obrigatório."))
            .IsRequired();

        builder.Property(x => x.Image)
            .HasColumnName("ImageUrl")
            .HasColumnType("text")
            .HasConversion(v => v == null ? null : v.Value, v => new(v));

        builder.Property(x => x.CNPJ)
            .HasColumnName("CNPJ")
            .HasColumnType("varchar(18)")
            .HasConversion(
                v => v.Value.Replace(".", "").Replace("-", "").Replace("/", ""),
                v => new(v))
            .IsRequired();

        builder.Property(x => x.OwnerId)
            .HasColumnName("OwnerId")
            .HasColumnType("uuid")
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasColumnName("CreatedAt")
            .HasColumnType("date")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("boolean")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.HasOne<User>()
            .WithOne()
            .HasForeignKey<Company>(x => x.OwnerId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}