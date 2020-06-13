using System;
using System.Collections.Generic;
using System.Text;
using CCL.Security.Identity;
namespace ClassLibrary1.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate, int pageNumber = 0, int pageSize = 10);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Request();
        void Accept(User visitor);
        string SomeState { get; set; }
    }

}
