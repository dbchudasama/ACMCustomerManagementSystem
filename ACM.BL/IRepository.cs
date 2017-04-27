using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    interface IRepository<T>
    {
        void Save(T type);
    }

    class Repository : IRepository<Product>
    {
        public void Save(Product type)
        {
            throw new NotImplementedException();
        }
    }
}
