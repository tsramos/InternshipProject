namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

    public class InternshipContractConfiguration : IEntityTypeConfiguration<InternshipContractModel>
    {
        public void Configure(EntityTypeBuilder<InternshipContractModel> builder)
        {
            builder.ToTable("InternshipContract");
            builder.HasKey(x => x.Id);
            builder.HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);
            builder.Property(p => p.HoursPerWeek);
            builder.Property(p => p.Course);
        }
    }
}
