using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Prototype
{
	interface IRepositoryBase<T>
	{
		IList<T> GetAllBase();
		T GetBase(int id);
		void AddBase(T t);
		void RemoveBase(int id);
		void SaveBase(T t);
		void ValidateBase(T t);
	}
}
