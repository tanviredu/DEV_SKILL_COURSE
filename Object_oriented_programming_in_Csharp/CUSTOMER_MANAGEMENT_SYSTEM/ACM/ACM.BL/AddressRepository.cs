using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class AddressRepository
    {
        public Address Retrieve(int addressid) {

            var address = new Address(addressid);

            if (addressid == 1) {

                address.AddressType = 1;
                address.StreenLine1 = "Bag End";
                address.StreerLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public List<Address> RetrieveByCustomerID(int customerid) {

            var addresslist = new List<Address>();

            Address address = new Address(1)
            {

                AddressType = 1,
                StreenLine1 = "Bag End",
                StreerLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "middle Earth",
                PostalCode = "144",


            };
            addresslist.Add(address);

            Address address2 = new Address(1)
            {

                AddressType = 2,
                StreenLine1 = "Bag End",
                StreerLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "middle Earth",
                PostalCode = "144",


            };

            addresslist.Add(address2);
            return addresslist;








        }


        public bool save(Address address) {

            return true;
        }
    }
}
