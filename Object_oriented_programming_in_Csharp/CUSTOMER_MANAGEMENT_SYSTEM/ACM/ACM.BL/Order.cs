using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderid)
        {
            OrderID = orderid;
        }

        public int CustomerID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }


        public bool Validate() {

            var isValid = true;

            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
