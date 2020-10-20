namespace InternshipProject.Repository.Repository.Entities
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;

    public class InternshipContractRepository : BaseRepository<InternshipContractModel>, IIntershipContract
    {
        public InternshipContractRepository(Context context) : base(context)
        {
        }
    }
}
