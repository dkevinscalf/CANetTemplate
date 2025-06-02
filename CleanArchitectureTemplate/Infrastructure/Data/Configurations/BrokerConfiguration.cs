using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class BrokerConfiguration : IEntityTypeConfiguration<Broker>
{
    public void Configure(EntityTypeBuilder<Broker> builder)
    {
        builder.Property(b => b.FirstName)
            .HasMaxLength(100);

        builder.Property(b => b.LastName)
            .HasMaxLength(100);

        builder.Property(b => b.Email)
            .HasMaxLength(200);

        builder.OwnsMany(b => b.AdditionalExternalCodes, codes =>
        {
            codes.WithOwner().HasForeignKey("BrokerId");
            codes.Property(ec => ec.System).HasMaxLength(50);
            codes.Property(ec => ec.Id).HasMaxLength(50);
            codes.ToTable("BrokerExternalCodes");
        });
    }
}
