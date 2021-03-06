﻿namespace InternshipProject.Repository.Configuration
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class Company : IEntityTypeConfiguration<CompanyModel>
    {
        public void Configure(EntityTypeBuilder<CompanyModel> builder)
        {
            builder.ToTable("Company");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.PersonResponsibleName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.IsIntegratingAgent).IsRequired();
            builder.Property(p => p.AgreementCode).IsRequired();
            builder.Property(p => p.CNPJ).HasMaxLength(14).IsRequired();
            builder.Property(p => p.Active).IsRequired();

            #region Relantionship

            builder.HasOne(x => x.Address).WithOne(a => a.Company).HasForeignKey<AddressModel>(x => x.Id);

            #endregion
        }
    }
}
