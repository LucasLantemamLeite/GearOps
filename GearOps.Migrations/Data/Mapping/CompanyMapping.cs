namespace GearOps.Migrations.Data.Mapping;

public sealed class CompanyMapping : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Companies");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("Id")
            .HasColumnType("UUID")
            .IsRequired();

        builder.OwnsOne(x => x.Name, name =>
        {
            name.Property(x => x.Value)
                .HasColumnName("Name")
                .HasColumnType("varchar(100)")
                .IsRequired();

            name.HasIndex(x => x.Value, "Unique_Key_Name_Companies")
                .IsUnique();
        });

        builder.OwnsOne(x => x.CNPJ, cnpj =>
        {
            cnpj.Property(x => x.Value)
                .HasColumnName("CNPJ")
                .HasColumnType("varchar(18)")
                .IsRequired();

            cnpj.HasIndex(x => x.Value, "Unique_Key_CNPJ_Companies")
                .IsUnique();
        });

        builder.OwnsOne(x => x.OwnerId, owned =>
        {
            owned.Property(p => p.Value)
                .HasColumnName("OwnerId")
                .HasColumnType("UUID")
                .IsRequired();
        });

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey("OwnerId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.OwnsOne(x => x.CreatedAt, created =>
        {
            created.Property(x => x.Value)
                .HasColumnName("CreatedAt")
                .HasColumnType("timestamp")
                .IsRequired();
        });

        builder.OwnsOne(x => x.Active, active =>
        {
            active.Property(x => x.Value)
                .HasColumnName("Active")
                .HasColumnType("boolean")
                .IsRequired();
        });
    }
}
