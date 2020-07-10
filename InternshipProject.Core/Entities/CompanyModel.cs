namespace InternshipProject.Core.Entities
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsIntegratingAgent { get; set; }
        public decimal AgreementCode { get; set; }
        public decimal CNPJ { get; set; }
        public string PersonResponsibleName { get; set; }
        public bool Active { get; set; }
        public AddressModel Address { get; set; }
        public DocumentsModel Document { get; set; }

        //TODO area de atuação ? Verificar possiveis apis externas...

    }
}
