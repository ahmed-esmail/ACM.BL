using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                var fullName = LastName;
                if (string.IsNullOrWhiteSpace(FirstName)) return fullName;
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ",";
                }

                fullName += FirstName;

                return fullName;
            }
        }

        public string EmailAddress { get; set; }
        public string WorkAddress { get; set; }
        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(LastName);

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        
         
    }
}