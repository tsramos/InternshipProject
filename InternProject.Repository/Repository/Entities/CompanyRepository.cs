namespace InternshipProject.Repository.Repository.Entities
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;

    public class CompanyRepository : BaseRepository<CompanyModel>, ICompanyRepository
    {
        public CompanyRepository(Context context) : base(context)
        {
        }
    }
}
