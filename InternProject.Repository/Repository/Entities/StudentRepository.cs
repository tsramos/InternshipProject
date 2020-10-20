namespace InternshipProject.Repository.Repository.Entities
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;
    public class StudentRepository : BaseRepository<StudentModel>, IStudentRepository
    {
        public StudentRepository(Context context) : base(context)
        {
        }
    }
}
