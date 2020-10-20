namespace InternshipProject.Repository.Repository.Entities
{
    using InternshipProject.Core.Entities;
    using InternshipProject.Core.Interfaces.Repository;

    public class DocumentRepository : BaseRepository<DocumentsModel>, IDocumentRepository
    {
        public DocumentRepository(Context context) : base(context)
        {
        }
    }
}
