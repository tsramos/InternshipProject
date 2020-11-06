namespace InternshipProject.Services
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;
    using InternshipProject.Core.Interfaces.Services;
    using InternshipProject.Services.Validator;
    using System;
    using System.Linq;

    public class CompanyService : BaseService<CompanyModel>, ICompanyService
    {
        public CompanyService(IBaseRepository<CompanyModel> baseRepository) : base(baseRepository)
        {
        }

        public override void Validate(CompanyModel entity)
        {
            CompanyValidator validator = new CompanyValidator();
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(x => x.ErrorMessage)));
            }
        }
    }
}
