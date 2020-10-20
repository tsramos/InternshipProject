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

        T Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        void Remove(Guid Id);
    }
}
