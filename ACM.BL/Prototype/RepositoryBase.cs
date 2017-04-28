using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Prototype
{
	//Needs to be a generic class that can take argument of type 'anything'. DBContext code needs to go in here.
	public class RepositoryBase : IRepositoryBase<RepositoryBase>
	{
		public void AddBase(RepositoryBase r)
		{
			throw new NotImplementedException();
		}

		public IList<RepositoryBase> GetAllBase()
		{
			throw new NotImplementedException();
		}

		public RepositoryBase GetBase(int id)
		{
			throw new NotImplementedException();
		}

		public void RemoveBase(int id)
		{
			throw new NotImplementedException();
		}

		public void SaveBase(RepositoryBase r)
		{
			throw new NotImplementedException();
		}

		public void ValidateBase(RepositoryBase r)
		{
			throw new NotImplementedException();
		}
	}
}
