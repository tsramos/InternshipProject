namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class CourseConfiguration : IEntityTypeConfiguration<CourseModel>
    {
        public void Configure(EntityTypeBuilder<CourseModel> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(x => x.Id);
            builder.HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Period).IsRequired();
            builder.Property(p => p.Education).IsRequired();
            builder.Property(p => p.InternshipRequired).IsRequired();
        }
    }
}
