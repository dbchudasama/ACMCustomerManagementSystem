using ACM.BL.CRM.Datastore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.CRM.Repository
{
    public interface ICRMRepository<T>
    {
        IQueryable<T> GetAll(IDatastore ctx); //TODO: you could use dependency injection to avoid passing this in everywhere!!!
        T Get(IDatastore ctx, int id);
        void Add(IDatastore ctx, T t);
        void Remove(IDatastore ctx, T t);
    }
}
