namespace InternshipProject.Core.Entities
{
    using InternshipProject.Core.Enuns;

    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool InternshipRequired { get; set; }
        public Period Period { get; set; }
        public Education Education { get; set; }
    }
}