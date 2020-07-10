namespace InternshipProject.Repository
{
    using InternshipProject.Core.Entities;
    using Microsoft.EntityFrameworkCore;

    public class Context : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<DocumentsModel> Documents { get; set; }
        public DbSet<InternshipContractModel> InternshipContracts { get; set; }

        private readonly string ConnectionString;
        public Context(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }

    }
}