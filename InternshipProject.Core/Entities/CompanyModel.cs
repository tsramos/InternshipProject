namespace InternshipProject.Core.Entities
{
    using System;
    using System.Collections.Generic;

    public class CompanyModel : EntityBase
    {
        public string Name { get; set; }
        public bool IsIntegratingAgent { get; set; }
        public decimal AgreementCode { get; set; }
        public decimal CNPJ { get; set; }
        public string PersonResponsibleName { get; set; }
        public bool Active { get; set; }
        public AddressModel Address { get; set; }
        public IEnumerable<DocumentsModel> Documents { get; set; }

        //TODO area de atuação ? Verificar possiveis apis externas...

    }
}
