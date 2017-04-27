using ACM.BL.CRM.Datastore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.DB
{
    class ACMDBContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
    }
}
