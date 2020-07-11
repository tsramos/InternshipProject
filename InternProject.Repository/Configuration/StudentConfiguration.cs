namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StudentConfiguration : IEntityTypeConfiguration<StudentModel>
    {
        public void Configure(EntityTypeBuilder<StudentModel> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(p => p.Birthday).HasMaxLength(8).IsRequired();
            builder.Property(p => p.IFPRCode).IsRequired();


            #region Relationship

            builder.HasOne(x => x.Course).WithMany(x => x.Students).HasForeignKey(c => c.Id);

            #endregion
        }
    }
}
