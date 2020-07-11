namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AddressConfiguration : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.CEP).HasMaxLength(8).IsRequired();
            builder.Property(p => p.Street).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Number).HasMaxLength(8).IsRequired();
            builder.Property(p => p.Complement).HasMaxLength(50);
            builder.Property(p => p.Neighborhood).HasMaxLength(50).IsRequired();
            builder.Property(p => p.City).HasMaxLength(50).IsRequired();
            builder.Property(p => p.State).HasMaxLength(50).IsRequired();
        }
    }
}
