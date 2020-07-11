namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

    public class CourseConfiguration : IEntityTypeConfiguration<CourseModel>
    {
        public void Configure(EntityTypeBuilder<CourseModel> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Period).IsRequired();
            builder.Property(p => p.Education).IsRequired();
            builder.Property(p => p.InternshipRequired).IsRequired();
        }
    }
}
