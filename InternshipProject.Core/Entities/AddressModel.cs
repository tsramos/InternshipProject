namespace InternshipProject.Core.Entities
{
    public class AddressModel
    {
        public AddressModel(int id, decimal cEP, string street, int number, string complement, string neighborhood, string city, string state)
        {
            Id = id;
            CEP = cEP;
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }

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