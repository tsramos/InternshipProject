namespace InternshipProject.Services
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;
    using InternshipProject.Core.Interfaces.Services;
    using InternshipProject.Services.Validator;
    using System;
    using System.Data;
    using System.Linq;
    
    public class StudentService : BaseService<StudentModel>, IStudentService
    {
        public StudentService(IStudentRepository studentRepository) : base(studentRepository)
        {
        }

        private readonly IStudentRepository repository;

        public override void Validate(StudentModel entity)
        {
            StudentValidator validator = new StudentValidator();
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(x => x.ErrorMessage)));
            }
        }
    }
}
