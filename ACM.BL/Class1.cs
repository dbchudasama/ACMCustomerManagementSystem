using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Test code written by Adrian to show an example of a base class can be made much more cleaner and efficient */

namespace ACM.BL
{
    public  class EntityBase2
    {

        public Guid ID { get; protected set; }
        public string Comment { get;  set; }

        protected virtual void Validate()
        {
            //'validate name is correct'
            if (this.Comment == null) throw new Exception("Comment is a required value.");
        }

        public void Save()
        {
            this.Validate();
            //' save to DB or storedproc'
        }

        public static List<EntityBase2> LoadAllBase()
        {
            return new List<EntityBase2>();
        }
    }

    public class Product2:EntityBase2
    {
        public Product2()
        {
            this.ID = Guid.NewGuid();

        }
         public string Name { get; set; }

        protected override void Validate()
        {
            // value product code

            base.Validate();
        }

        public static List<Product2> LoadAll()
        {
            return new List<Product2>();
        }

        public static List<Product2> LoadMany(string filter)
        {
            return new List<Product2>();
        }

        public static Product2 LoadOne()
        {
            return new Product2();
        }
    }

    class TestHarness
    {
        void test()
        {
            var p = new Product2();
            p.Save();

            var p2 = new Product2();
            p2.Save();

            var products = new List<Product2>() { p, p2 };



            var products2 = Product2.LoadAll();
            
        }

    }
}
