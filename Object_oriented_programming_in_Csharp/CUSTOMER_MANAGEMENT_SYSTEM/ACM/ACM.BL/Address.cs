using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressid)
        {
            AddressID = addressid;
        }

        public int AddressID { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreenLine1 { get; set; }
        public string StreerLine2 { get; set; }


        public bool Validate() {
            var isValid = true;

            if (PostalCode == null) isValid = false;
            return isValid;
        
        }

    }
}
