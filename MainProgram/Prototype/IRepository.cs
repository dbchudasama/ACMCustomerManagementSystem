using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Prototype
{
	public interface IRepository
	{
		void GetAll();
		void Get();
		void Add();
		void Remove();
		void Save();
		void Validate();
	}
}
