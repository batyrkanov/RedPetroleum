﻿using X.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPetroleum.Models.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IPagedList<T> GetAllIndex(int pageNumber, int pageSize, string search);
        T Get(Guid id);
        void Create(T item);
        void Update(T item);
        void Delete(Guid id);
        Task<T> GetAsync(Guid? id);
    }
}
