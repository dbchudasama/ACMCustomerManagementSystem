using ACM.BL.CRM.Datastore.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.CRM.Datastore
{
    public interface IDatastore : IDisposable //ensures we can use the using() syntax
    {
        IRepository<Address> Address { get; }
    }
}
