namespace InternshipProject.Core.Entities
{
    public class InternshipContractModel : DocumentsModel
    {        
        public CourseModel Course { get; set; }
        public int HoursPerWeek { get; set; }
        //Adicionar area de atuação ?
    }
}
