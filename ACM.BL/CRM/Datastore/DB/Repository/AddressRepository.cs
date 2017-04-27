using ACM.BL.CRM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL.CRM.Datastore;

namespace ACM.BL
{
    public class AddressRepository : ICRMRepository<Address>
    {
        public void Add(IDatastore ctx, Address t)
        {
            throw new NotImplementedException();
        }

        public Address Get(IDatastore ctx, int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Address> GetAll(IDatastore ctx)
        {
            throw new NotImplementedException();
        }

        public void Remove(IDatastore ctx, Address t)
        {
            throw new NotImplementedException();
        }
    }
}
