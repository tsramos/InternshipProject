namespace InternshipProject.Core.Entities
{
    public class InternshipContractModel : DocumentsModel
    {
        public int Id { get; set; }
        public CourseModel Course { get; set; }
        public int HoursPerWeek { get; set; }
        //Adicionar area de atuação ?
    }
}
