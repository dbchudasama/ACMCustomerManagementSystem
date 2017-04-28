using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	//Repository Interface to use with repository files
	interface IRepository<T>
	{
		//GENERIC approach. Save method to take in any object Type
		void Save(T type);
	}
                                                                                                                              
	//Class Repository inherits from the IRepository interface
	class RepositoryInternal : IRepository<Product>
	{
		public void Save(Product type)
		{
			throw new NotImplementedException();
		}
	
	}

}
