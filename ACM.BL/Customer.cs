using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        //Constructor for Customer Class
        public Customer ()
        {

        }

        //Constructor for Customer with customerId as the parameter
        public Customer(int customerId)
        {
            //'this' refers to the current instance of the customer object being used
            this.CustomerId = customerId;
        }

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
        public int CustomerId { get; private set; }

        //Fullname of customer. No setter only a getter as nothing should be able to change the value of this property
        public string FullName
        {
            get
            {
                //Adding in logic to test for whether ',' is needed if first or last name is empty (For automated testing code to pass)
                string fullname = FirstName;
                //If the last name is populated
                if(!string.IsNullOrWhiteSpace(LastName))
                    {
                        //If the first name is populated
                        if(!string.IsNullOrWhiteSpace(fullname))
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

        //Method 'Save' to save the defined customer
        public bool Save()
        {
            return true;
        }

        //Method to retrieve A SPECIFIC customer - Using the customerId as a parameter
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        //Second Retrieve Method that returns a LIST of customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        //Method 'Validate' to make sure name is valid
        public bool Validate()
        {
            var isValid = true;
            
            //If either first or last names are empty then validation will fail
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }
    }
}
