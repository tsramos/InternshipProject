namespace InternshipProject.Core.Entities
{
    using System;
    public class AddressModel : EntityBase
    {
        public decimal CEP { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public CompanyModel Company { get; set; }

    }
}