using FluentValidation;
using InternshipProject.Core.Entities;

namespace InternshipProject.Services.Validator
{
    public class CourseValidator :AbstractValidator<CourseModel>
    {
        public CourseValidator()
        {
            this.RuleFor(x => x.Education)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório.");

            this.RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório.");
        }
    }
}
