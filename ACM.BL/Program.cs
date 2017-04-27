using ACM.BL.CRM.Datastore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    static class CRMTest {
        public static void Run(BL.CRM.Datastore.IDatastore ctx)
        {
            Console.WriteLine("adding addr 1");
            ctx.Address.Add(new Address()
            {
                AddressType = 0,
                City = "brighton",
                Country = "uk",
                PostCode = "BN1",
                State = "test",
                Street = "test",
                CustomerId = 0
            });

            Console.WriteLine("printing contents");
            ctx.Address.GetAll().ToList().ForEach(entry => Console.WriteLine(JsonConvert.SerializeObject(entry)));

            Console.WriteLine("adding addr 2");
            ctx.Address.Add(new Address()
            {
                AddressType = 0,
                City = "derby",
                Country = "uk",
                PostCode = "DB1",
                State = "test",
                Street = "test",
                CustomerId = 0
            });

            Console.WriteLine("printing contents");
            ctx.Address.GetAll().ToList().ForEach(entry => Console.WriteLine(JsonConvert.SerializeObject(entry)));

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

            Console.WriteLine("removing first record");
            var removeFirst = ctx.Address.GetAll().Where(addr => addr.City == "brighton").First();
            Console.WriteLine(JsonConvert.SerializeObject(removeFirst));
            ctx.Address.Remove(removeFirst.AddressId);

            Console.WriteLine("searching and removing 2nd record");
            var removeSecond = ctx.Address.GetAll().Where(addr => addr.City == "derby").First();
            Console.WriteLine(JsonConvert.SerializeObject(removeSecond));
            ctx.Address.Remove(removeSecond.AddressId);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new DBDatastore())
            {
                CRMTest.Run(ctx);
            }

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}
