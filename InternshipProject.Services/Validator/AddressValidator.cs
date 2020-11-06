namespace InternshipProject.Services.Validator
{
    using FluentValidation;
    using InternshipProject.Core.Entities;

    public class AddressValidator : AbstractValidator<AddressModel>
    {
        public AddressValidator()
        {
            this.RuleFor(x => x.CEP)
                .NotEmpty()
                .NotNull()
                .WithMessage("Campo obrigatório");

            this.RuleFor(x => x.City)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório");

            this.RuleFor(x => x.Neighborhood)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório");

            this.RuleFor(x => x.Street)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório");

            this.RuleFor(x => x.State)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório");

            this.RuleFor(x => x.Number)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório");
        }
    }
}
