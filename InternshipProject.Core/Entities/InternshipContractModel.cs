﻿namespace InternshipProject.Core.Entities
{
    using System;
    public class InternshipContractModel : EntityBase
    {
        public CourseModel Course { get; set; }
        public int HoursPerWeek { get; set; }
        public DocumentsModel Document { get; set; }
    }
}
