using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Prototype
{
	/*
	public class Order : RepositoryBase, IRepository
	{
		
		public int CustomerId { get; set; }
		public int ShippingAddressId { get; set; }
		//Nullable value type. Using DateTimeOffset as this is very useful in calculating offsets for different time zones for different countries. Can get the time in local time.
		public DateTimeOffset? OrderDate { get; set; }
		public int OrderId { get; private set; }
		//public List<OrderItem> orderItems { get; set; }

		Order o = new Order();

		public void Add()
		{
			base.AddBase(o);
		}

		public void Get()
		{
			base.GetBase(OrderId);
		}

		public void GetAll()
		{
			base.GetAllBase();
		}

		public void Remove()
		{
			base.RemoveBase(OrderId);
		}

		public void Save()
		{
			base.SaveBase(o);
		}

		public void Validate()
		{
			base.ValidateBase(o);
		}	
	}
	*/
}
