
namespace GearOps.Migrations.Data.Mapping;

public sealed class DeviceMap : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> builder)
    {
        builder.ToTable("Devices");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
           .HasColumnName("Name")
           .HasColumnType("varchar(100)")
           .HasConversion(v => v.Value, v => new(v, "Nome da empresa é obrigatório."))
           .IsRequired();

        builder.Property(x => x.Status)
            .HasColumnName("Status")
            .HasColumnType("smallint")
            .HasConversion(v => v.Value, v => new((int)v))
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("Description")
            .HasColumnType("varchar(150)")
            .HasConversion(v => v == null ? null : v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Start)
            .HasColumnName("Start")
            .HasColumnType("date")
            .HasConversion(v => v == null ? null : v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Return)
            .HasColumnName("Return")
            .HasColumnType("date")
            .HasConversion(v => v == null ? null : v.Value, v => new(v))
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

        builder.HasOne<DeviceType>()
            .WithMany()
            .HasForeignKey(x => x.DeviceTypeId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}