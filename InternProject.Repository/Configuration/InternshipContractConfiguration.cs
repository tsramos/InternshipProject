namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class InternshipContractConfiguration : IEntityTypeConfiguration<InternshipContractModel>
    {
        public void Configure(EntityTypeBuilder<InternshipContractModel> builder)
        {
            builder.ToTable("InternshipContract");
            builder.Property(p => p.HoursPerWeek);
            builder.Property(p => p.Course);
        }
    }
}
