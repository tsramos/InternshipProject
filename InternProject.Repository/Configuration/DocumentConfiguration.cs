namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DocumentConfiguration : IEntityTypeConfiguration<DocumentsModel>
    {
        public void Configure(EntityTypeBuilder<DocumentsModel> builder)
        {
            builder.ToTable("Documents");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Start).IsRequired();
            builder.Property(p => p.End).IsRequired();
            builder.Property(p => p.Comments).HasMaxLength(255);

            #region RelationShip

            builder.HasOne(x => x.Student).WithMany(x => x.Documents).HasForeignKey(x => x.Id);
            builder.HasOne(x => x.Company).WithMany(x => x.Documents).HasForeignKey(x => x.Id);

            #endregion
        }
    }
}
