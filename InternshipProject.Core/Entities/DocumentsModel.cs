namespace InternshipProject.Core.Entities
{
    using InternshipProject.Core.Enuns;
    using System;

    public class DocumentsModel
    {
        DocumentType DocumentType { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public CompanyModel Company { get; set; }
        public StudentModel Student { get; set; }
        public string Comments { get; set; }
    }
}