namespace InternshipProject.Repository.Repository.Entities
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;

    public class CourseRepository : BaseRepository<CourseModel>, ICourseRepository
    {
        public CourseRepository(Context context) : base(context)
        {
        }
    }
}
