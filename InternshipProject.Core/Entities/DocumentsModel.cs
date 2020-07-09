namespace InternshipProject.Core.Entities
{
    using InternshipProject.Core.Enuns;
    using System;

    public class DocumentsModel
    {
        public DocumentsModel(DocumentType documentType, DateTime start, DateTime end, CompanyModel company, StudentModel student, string comments)
        {
            DocumentType = documentType;
            Start = start;
            End = end;
            Company = company;
            Student = student;
            Comments = comments;
        }

        DocumentType DocumentType { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public CompanyModel Company { get; set; }
        public StudentModel Student { get; set; }
        public string Comments { get; set; }
    }
}