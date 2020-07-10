namespace InternshipProject.Core.Entities
{
    public class AddressModel
    {       
        public int Id { get; set; }
        public decimal CEP { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}