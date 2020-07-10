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
            builder.Property(p => p.Start).IsRequired();
            builder.Property(p => p.End).IsRequired();
            builder.Property(p => p.Comments).HasMaxLength(255).IsRequired();
        }
    }
}
