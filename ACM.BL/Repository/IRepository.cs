using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repository
{
	public interface IRepository<T>
	{
		IList<T> GetAll();
		T Get(int id);
		void Add(T t);
		void Remove(int id);
	}
}
