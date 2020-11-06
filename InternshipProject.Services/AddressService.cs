namespace InternshipProject.Services
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;
    using InternshipProject.Core.Interfaces.Services;
    using InternshipProject.Services.Validator;
    using System;
    using System.Linq;

    public class AddressService : BaseService<AddressModel>, IAddressService
    {
        public AddressService(IBaseRepository<AddressModel> baseRepository) : base(baseRepository)
        {
        }

        public override void Validate(AddressModel entity)
        {
            AddressValidator validator = new AddressValidator();
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(x => x.ErrorMessage)));
            }
        }
    }
}
