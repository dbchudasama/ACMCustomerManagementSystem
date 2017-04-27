using ACM.BL.DB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : IEntity
    {
        public DbSet<Address> AddressList { get; set; }
       
        public int CustomerId { get; set; } //TODO: Could have just called it Id.. 
        public int CustomerType { get; set; } //TODO see above but type
        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                //Adding in logic to test for whether ',' is needed if first or last name is empty (For automated testing code to pass)
                string fullname = FirstName;
                //If the last name is populated
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    //If the first name is populated
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        //Add a comma after it
                        fullname += ", ";
                    }
                    //Now add the Last name
                    fullname += LastName;
                }

                //Return the fullname - First Name + Last Name
                return fullname;
            }
        }

        //Method 'Validate' to make sure name is valid
        public bool Validate()
        {
            //If either first or last names are empty then validation will fail
            return (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(EmailAddress)) ? false : true;
        }
    }
}
