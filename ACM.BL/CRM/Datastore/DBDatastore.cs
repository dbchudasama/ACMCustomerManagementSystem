using ACM.BL.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL.CRM.Datastore.DB;

namespace ACM.BL.CRM.Datastore
{
    public class DBDatastore : IDatastore
    {
        private readonly IRepository<Address> _address;

        public IRepository<Address> Address { get { return _address; } }

        public DBDatastore()
        {
            _address = new Addresses();
        }

        public void Dispose()
        {

        }
    }
}
