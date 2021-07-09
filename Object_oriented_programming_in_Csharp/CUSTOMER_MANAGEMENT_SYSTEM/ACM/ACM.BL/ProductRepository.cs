using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productid) {

            var product = new Product(productid);
            if (productid == 2) {

                product.ProductName = "Flower";
                product.ProductDescription = "4 Bright Flower";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Product product) {

            return true;
        }
    }
}
