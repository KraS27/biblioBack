﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();

        public Task Create(T entity);

        public Task Delete(T entity);

        public Task<T> Update(T entity);
    }
}
