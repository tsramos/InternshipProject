namespace InternshipProject.Core.Interfaces.Repository
{
    using InternshipProject.Core.Entities;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IBaseRepository<T> where T : EntityBase
    {
        IQueryable<T> Get();

        T Get(Guid Id);

        Task<T> Add(T entity);

        Task<T> Update(Guid Id, T entity);

        Task<T> Remove(T entity);

        Task<T> Remove(Guid Id);

        void SaveChanges();
    }
}
