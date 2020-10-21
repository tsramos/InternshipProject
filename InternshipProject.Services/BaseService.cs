using InternshipProject.Core.Entities;
using InternshipProject.Core.Interfaces.Repository;
using InternshipProject.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternshipProject.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : EntityBase
    {
        private readonly IBaseRepository<T> baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public T Add(T entity)
        {
            this.Validate(entity);
            return this.baseRepository.Add(entity);
        }

        public IList<T> Get()
        {
            return this.baseRepository.Get().ToList();
        }

        public T Get(Guid Id)
        {
            return this.baseRepository.Get(Id);
        }

        public void Remove(T entity)
        {
            this.baseRepository.Remove(entity);
        }

        public void Remove(Guid Id)
        {
            this.Remove(Id);
        }

        public void Update(T entity)
        {
            this.Validate(entity);
            this.baseRepository.Update(entity);
        }

        public abstract void Validate(T entity);
    }
}
