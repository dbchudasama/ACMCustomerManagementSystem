using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    //Base class so no instance of this class should be created hence making it abstract
    public abstract class EntityBase
    {
        //Defines if the item is active or deleted
        public EntityStateOption EntityState { get; set; }

        //Defines if the object type has been changed
        public bool HasChanges { get; set; }

        //This property defines if the object type is a NEW one
        public bool IsNew { get; set; }
        //public string Comment { get; set; }
        public Guid ID { get; protected set; } //Guid is a long mixed character number (unique for each object created)


        /* Avoid doing the below as this makes the getter a method. Getter needs to be soft not not code heavy. Also not efficient as Validate will be called everytime
         * isValid is called.
         

        //Defines if the data is currently valid
        public bool IsValid
        {
            get
            {
                //Whenever IsValid is trigger it will make a call to the Validate() method
                return Validate();
            }
        }
        */

        //Making the method overidden hence using the 'Abstract' keyword. As the child classes are inheriting from this they must implement the method in their
        //relevant class files
        public abstract bool Validate();

        public void Save()
        {

            this.Validate();
            //Code to store object in Database goes here. Won't actually implement as this is a sample code demonstrating understanding

        }

        public static List<EntityBase> LoadBaseAll()
        {
            return new List<EntityBase>();
        }
    }
}
