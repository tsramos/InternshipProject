namespace InternshipProject.Core.Entities
{
    using System;

    public class StudentModel
    {
        public StudentModel(string name, DateTime birthday, string cpf, CourseModel course, decimal IFPRCode)
        {
            Name = name;
            Birthday = birthday;
            Cpf = cpf;
            Course = course;
            this.IFPRCode = IFPRCode;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Cpf { get; set; }
        public CourseModel Course { get; set; }
        public decimal IFPRCode { get; set; }
    }
}
