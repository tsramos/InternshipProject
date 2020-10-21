using FluentValidation;
using InternshipProject.Core.Entities;

namespace InternshipProject.Services.Validator
{
    public class StudentValidator : AbstractValidator<StudentModel>
    {
        public StudentValidator()
        {
            this.RuleFor(x => x.IFPRCode)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo obrigatório");

			this.RuleFor(x => x.Name)
				.NotEmpty()
				.NotNull().WithMessage("Campo obrigatório!")
				.MinimumLength(4).WithMessage("Nome com menos de 4 caracteres")
				.MaximumLength(100).WithMessage("Nome com mais de 100 caracteres");

            this.RuleFor(x => x.Cpf)
				.NotEmpty()
				.NotNull().WithMessage("Campo obrigatório!")
                .Must((x) =>
                {
                    #region ValidaCpf

                    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
					int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
					string tempCpf;
					string digito;
					int soma;
					int resto;
					x = x.Trim();
					x = x.Replace(".", "").Replace("-", "");
					if (x.Length != 11)
						return false;
					tempCpf = x.Substring(0, 9);
					soma = 0;

					for (int i = 0; i < 9; i++)
						soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
					resto = soma % 11;
					if (resto < 2)
						resto = 0;
					else
						resto = 11 - resto;
					digito = resto.ToString();
					tempCpf = tempCpf + digito;
					soma = 0;
					for (int i = 0; i < 10; i++)
						soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
					resto = soma % 11;
					if (resto < 2)
						resto = 0;
					else
						resto = 11 - resto;
					digito = digito + resto.ToString();
					return x.EndsWith(digito);

                    #endregion
                })
				.WithMessage("Cpf inválido!");

			this.RuleFor(x => x.Birthday)
				.NotNull()
				.NotEmpty()
				.WithMessage("Campo obrigatório");

			this.RuleFor(x => x.Course)
				.NotEmpty()
				.NotNull()
				.WithMessage("Componente Curricular obrigatório");
        }
    }
}
