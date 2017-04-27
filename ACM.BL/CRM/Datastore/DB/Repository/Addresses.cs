using ACM.BL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.CRM.Datastore.DB
{
    class Addresses : IRepository<Address>
    {
        public void Add(Address address)
        {
            if (address == null)
                return;

            using(var ctx = new ACMDBContext())
            {
                //if the record exists dont insert, assume we are in good state, the record actually exists
                if(this.GetAll().Where(addr => address.Equals(addr)).FirstOrDefault() == null)
                {
                    ctx.Address.Add(address);
                    ctx.SaveChanges();
                }
            }
        }

        public Address Get(int id)
        {
            using (var ctx = new ACMDBContext())
            {
                return ctx.Address.Where(addr => addr.AddressId == id).FirstOrDefault<Address>();
            }
        }

        public IList<Address> GetAll()
        {
            using (var ctx = new ACMDBContext())
            {
                return ctx.Address.ToList<Address>();
            }
        }

        public void Remove(int id)
        {
            using (var ctx = new ACMDBContext())
            {
                var addrToRemove = ctx.Address.FirstOrDefault(addr => addr.AddressId == id);

                if (addrToRemove != null)
                {

                    ctx.Address.Remove(addrToRemove);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
