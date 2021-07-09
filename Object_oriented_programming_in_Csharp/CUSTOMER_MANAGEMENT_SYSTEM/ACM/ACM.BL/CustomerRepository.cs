using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
          AddressRepository  addressrepository = new AddressRepository();
        }

        private AddressRepository addressrepository { get; set; }
        public Customer Retrieve(int CustomerId) {
            Customer customer = new Customer(CustomerId);

            if (CustomerId == 1) {
                customer.EmailAddress = "tanviredu2018@gmail.com";
                customer.FirstName = "Tanvir";
                customer.LastName = "Rahman";
                customer.AddressList = addressrepository.RetrieveByCustomerID(CustomerId);
            
            }
            return customer;

        
        }

        public bool Save(Customer customer) {

            return true;
        }

    }
}
