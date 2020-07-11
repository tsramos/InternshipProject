namespace InternshipProject.Core.Entities
{
    using InternshipProject.Core.Enuns;
    using System;
    using System.Collections.Generic;

    public class CourseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool InternshipRequired { get; set; }
        public Period Period { get; set; }
        public Education Education { get; set; }
        public IEnumerable<StudentModel> Students { get; set; }
        public InternshipContractModel Contract { get; set; }
    }
}