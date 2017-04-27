using System.Collections.Generic;
using System.Linq;

namespace ACM.BL.CRM.Datastore.DB
{
    public interface IRepository<T>
    {
        IList<T> GetAll(); //TODO: you could use dependency injection to avoid passing this in everywhere!!!
        T Get(int id);
        void Add(T t);
        void Remove(int id);
    }
}