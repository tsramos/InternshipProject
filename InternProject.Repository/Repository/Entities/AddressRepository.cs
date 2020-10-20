namespace InternshipProject.Repository.Repository.Entities
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;
    public class AddressRepository : BaseRepository<AddressModel>, IAddressRepository
    {
        public AddressRepository(Context context) : base(context)
        {
        }
    }
}
