namespace InternshipProject.Core.Entities
{
    using InternshipProject.Core.Enuns;

    public class CourseModel
    {
        public CourseModel(string name, bool internshipRequired, Period period, Education education)
        {
            Name = name;
            InternshipRequired = internshipRequired;
            Period = period;
            Education = education;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool InternshipRequired { get; set; }
        public Period Period { get; set; }
        public Education Education { get; set; }
    }
}