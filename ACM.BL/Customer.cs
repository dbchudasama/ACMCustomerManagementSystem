using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        //Private as no access to this
        private AddressRepository addressRepository { get; set; }

        //Constructor overloaading for Customer Class
        public Customer()
            //: this(0)//Constructor chanining
        {
            //New Guid (Mixed character and digit number) allocation
            this.ID = Guid.NewGuid();

            //'this' refers to the current instance of the customer object being used
            //this.CustomerId = customerId;
            AddressList = new List<Address>();
            addressRepository = new AddressRepository();
        }

        //Addresss
        public List<Address> AddressList { get; set; }

        //Customer type variable
        public int CustomerType { get; set; }

        //Static variable declaration for instance count
        public static int InstanceCount { get; set; }

        //Last Name property
        public string LastName { get; set; }

        //First Name property
        public string FirstName { get; set; }

        //Email address property
        public string EmailAddress { get; set; }
        
        //Customer ID property - Here limiting the set command so that only I can set this property. No code outside this class can set this property
        //as this is a key property
       // public int CustomerId { get; private set; }

        //Fullname of customer. No setter only a getter as nothing should be able to change the value of this property
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
        public override bool Validate()
        {
            //If either first or last names are empty then validation will fail
            return (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(EmailAddress)) ? false : true;
        }

        //Method to create a customer - Using the customerId as a parameter
        public void CreateCustomer(Customer c)
        {
                //Building customer
                EmailAddress = "divyesh@me.com";
                FirstName = "Divyesh";
                LastName = "Chudasama";
                AddressList = addressRepository.LoadCustomerAddress(c).ToList();
        }
    }
}
