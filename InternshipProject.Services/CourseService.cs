namespace InternshipProject.Services
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;
    using InternshipProject.Core.Interfaces.Services;
    using InternshipProject.Services.Validator;
    using System;
    using System.Linq;

    public class CourseService : BaseService<CourseModel>, ICourseService
    {
        public CourseService(IBaseRepository<CourseModel> baseRepository) : base(baseRepository)
        {
        }

        public override void Validate(CourseModel entity)
        {
            CourseValidator validator = new CourseValidator();
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(x => x.ErrorMessage)));
            }
        }
    }
}
