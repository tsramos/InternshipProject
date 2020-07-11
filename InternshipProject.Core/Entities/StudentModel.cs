﻿namespace InternshipProject.Core.Entities
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class StudentModel
    {       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Cpf { get; set; }
        public CourseModel Course { get; set; }
        public decimal IFPRCode { get; set; }
        public IEnumerable<DocumentsModel> Documents { get; set; }
    }
}
