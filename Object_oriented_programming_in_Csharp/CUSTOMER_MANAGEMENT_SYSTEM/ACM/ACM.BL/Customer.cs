using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer():this(0)
        {
                   
        }
        public Customer(int customerid)
        {
            CustomerID = customerid;

            /// initialize the address list
            AddressList = new List<Address>();
        }

        
        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public string FullName
        {
            get {
                return FirstName + " " + LastName;
            
            }
        }

        public static int instanceCount { get; set; }

        public bool Validate() {

            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) {
                isValid = false;
            
            }
            if (string.IsNullOrWhiteSpace(EmailAddress)) {
                isValid = false;
                
            }
            return isValid;
        }

       


    }
}
