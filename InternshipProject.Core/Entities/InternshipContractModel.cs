namespace InternshipProject.Core.Entities
{
    using System;
    public class InternshipContractModel
    {
        public Guid Id { get; set; }
        public CourseModel Course { get; set; }
        public int HoursPerWeek { get; set; }
        public DocumentsModel Document { get; set; }


    }
}
