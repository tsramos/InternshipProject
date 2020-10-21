using InternshipProject.Core.Entities;
using System;
using System.Collections.Generic;

namespace InternshipProject.Core.Interfaces.Services
{
    public interface IBaseService<T> where T : EntityBase
    {
        IList<T> Get();

        T Get(Guid Id);

        T Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        void Remove(Guid Id);
    }
}
