using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACM.BL
{
	/*
	//Context class for the Customer Table 
	public partial class ACMDBEntities : DbContext
	{
		//Passing in class name into base constructor
		public ACMDBEntities()
			: base("name=ACMTest")
		{

		}

		//Overidding the OnModelCreating method to my own model design
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Customer>()
				.HasKey(i => i.ID);
			modelBuilder.Entity<Customer>()
				.Property(i => i.ID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.HasColumnName("CustomerId");
		}

		//Mapping taking place
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Address> Addresses { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
	}
	*/
}
