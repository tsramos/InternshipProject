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
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.HoursPerWeek);

            #region Relationship

            builder.HasOne(x => x.Document).WithOne(x => x.InternshipContract).HasForeignKey<DocumentsModel>(x => x.Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Course).WithOne(x => x.Contract).HasForeignKey<CourseModel>(x => x.Id);

            #endregion
        }
    }
}
