using Microsoft.EntityFrameworkCore.Design;

namespace InternshipProject.Repository
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            return new Context("Host=localhost;Database=InternshipManager;Username=postgres;Password=postgres;Port=5432");
        }
    }
}
