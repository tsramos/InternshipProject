namespace InternshipProject.Services
{
    using InternshipProject.Core.Interfaces.Services;
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;
    using InternshipProject.Services.Validator;
    using System;
    using System.Linq;

    public class DocumentService : BaseService<DocumentsModel>, IDocumentService
    {
        public DocumentService(IBaseRepository<DocumentsModel> baseRepository) : base(baseRepository)
        {
        }

        public override void Validate(DocumentsModel entity)
        {
            DocumentValidator validator = new DocumentValidator();
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(x => x.ErrorMessage)));
            }
        }
    }
}
