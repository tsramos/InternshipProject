using FluentValidation;
using InternshipProject.Core.Entities;

namespace InternshipProject.Services.Validator
{
    public class DocumentValidator : AbstractValidator<DocumentsModel>
    {
        public DocumentValidator()
        {
            this.RuleFor(x => x.Start)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório.");

            this.RuleFor(x => x.End)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório.");

            this.RuleFor(x => x.Company)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório.");            
        }
    }
}
