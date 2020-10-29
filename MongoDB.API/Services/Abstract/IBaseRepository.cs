using MongoDB.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.API.Services
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetList();
        T GetById(string id);
        T Create(T document);
        void Update(string id, T document);
        void Delete(string id, T document);
    }
}
