namespace InternshipProject.Core.Entities
{
    using System;
    using System.Collections.Generic;

    public class StudentModel : EntityBase
    {       
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Cpf { get; set; }
        public CourseModel Course { get; set; }
        public decimal IFPRCode { get; set; }
        public IEnumerable<DocumentsModel> Documents { get; set; }
    }
}
