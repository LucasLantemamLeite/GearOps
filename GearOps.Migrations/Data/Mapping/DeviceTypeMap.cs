namespace GearOps.Migrations.Data.Mapping;

public sealed class DeviceTypeMap : IEntityTypeConfiguration<DeviceType>
{
    public void Configure(EntityTypeBuilder<DeviceType> builder)
    {
        builder.ToTable("DeviceTypes");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Image)
            .HasColumnName("ImageUrl")
            .HasColumnType("text")
            .HasConversion(v => v == null ? null : v.Value, v => new(v));

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(100)")
            .HasConversion(v => v.Value, v => new(v, "Nomo do tipo de dispositivo é obrigatório."))
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasColumnName("CreatedAt")
            .HasColumnType("date")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.HasOne<Company>()
            .WithMany()
            .HasForeignKey(x => x.CompanyId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}