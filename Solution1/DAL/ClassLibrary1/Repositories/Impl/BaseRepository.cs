﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.EF;
using CCL.Security.Identity;
namespace ClassLibrary1.Repositories.Impl
{

    public  class BaseRepository<T>
        : IRepository<T>
        where T : class
    {
        private readonly DbSet<T> _set;
        private readonly DbContext _context;
​
public string SomeState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BaseRepository(DbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }
​
        public void Create(T item)
        {
            _set.Add(item);
        }
​
       public void Delete(int id)
        {
            var item = Get(id);
            _set.Remove(item);
        }
​
         public IEnumerable<T> Find(
            Func<T, bool> predicate,
            int pageNumber = 0,
            int pageSize = 10)
        {
            return
                _set.Where(predicate)
                    .Skip(pageSize * pageNumber)
                    .Take(pageNumber)
                    .ToList();
        }
​
            public T Get(int id)
        {
            return _set.Find(id);
        }
​
            public IEnumerable<T> GetAll()
        {
            return _set.ToList();
        }
​
            public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
        public void Request() { }
        public  void Accept(User visitor)
        {
            BaseRepository<T> baseRepository = this;
            visitor.VisitElementA(baseRepository);
        }
        public void OperationA()
        { }

    }

}
