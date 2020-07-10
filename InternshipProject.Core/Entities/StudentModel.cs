namespace InternshipProject.Core.Entities
{
    using System;

    public class StudentModel
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Cpf { get; set; }
        public CourseModel Course { get; set; }
        public decimal IFPRCode { get; set; }
    }
}
