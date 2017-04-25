using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Example code written by Adrian to show how a static method 'Product' can be invoke on any variable instead of having to invoke an object to call it*/

namespace ACM.BLTest
{
    class Class1
    {
        void test()
        {
            var p = new ACM.BL.Product();
            //p.Save();
        }
    }
}
