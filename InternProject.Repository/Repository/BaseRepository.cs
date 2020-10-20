using InternshipProject.Core.Entities;
using InternshipProject.Core.Interfaces.Repository;
using System;
using System.Linq;

namespace InternshipProject.Repository.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {

        private readonly Context context;
        public BaseRepository(Context context)
        {
            this.context = context;
        }
        public T Add(T entity)
        {
           this.context.Set<T>().Add(entity);
           return entity;
        }

        public IQueryable<T> Get()
        {
            return this.context.Set<T>();
        }

        public T Get(Guid Id)
        {
            return this.context.Set<T>().FirstOrDefault(x => x.Id.Equals(Id));
        }

        public void Remove(T entity)
        {
            this.context.Set<T>().RemoveRange(entity);
            this.context.SaveChanges();           
        }

        public void Remove(Guid Id)
        {
            var entity = this.context.Set<T>().FirstOrDefault(x => x.Id.Equals(Id));
            this.context.Remove(entity);
            this.context.SaveChanges();
        }

        public void Update(T entity)
        {
            this.context.Update(entity);
        }
    }
}
