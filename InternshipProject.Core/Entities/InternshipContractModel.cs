using InternshipProject.Core.Enuns;
using System;

namespace InternshipProject.Core.Entities
{
    class InternshipContractModel : DocumentsModel
    {
        public InternshipContractModel(DocumentType documentType,DateTime start, DateTime end,
                                       CompanyModel company, StudentModel student, string comments,
                                       int id,CourseModel course,int hoursPerWeek) 
                                       : base(documentType, start, end, company, student, comments )
        {
            Id = id;
            Course = course;
            HoursPerWeek = hoursPerWeek;
        }

        public int Id { get; set; }
        public CourseModel Course { get; set; }
        public int HoursPerWeek { get; set; }
        //Adicionar area de atuação ?
    }
}
