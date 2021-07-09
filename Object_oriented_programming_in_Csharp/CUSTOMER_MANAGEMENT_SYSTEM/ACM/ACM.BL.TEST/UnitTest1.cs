using System;
using Xunit;
using ACM.BL;
namespace ACM.BL.TEST
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange 
            Customer customer = new Customer();
            customer.FirstName = "Tanvir";
            customer.LastName = "Rahman";
            var expected = "Tanvir Rahman";

            // act
            var actualName = customer.FullName;

            //Assert
            Assert.Equal(expected, actualName);



        }

        [Fact]
        public void Test2() {
            // Arrange
            Customer customer  = new Customer();
            customer.FirstName = "Tanvir";
            customer.LastName = "";
            var expected = "Tanvir";

            //Act
            var actualName = "Tanvir";

            // Assert
            Assert.Equal(expected, actualName);

        }
        [Fact]
        public void StaticTest() {
            
            // arrange
            var c1 = new Customer();
            c1.FirstName = "Tanvir";
            Customer.instanceCount += 1;
            
            
            var c2 = new Customer();
            c1.FirstName = "Tanvir";
            Customer.instanceCount += 1;
            
            
            var c3 = new Customer();
            c1.FirstName = "Tanvir";
            Customer.instanceCount += 1;

            //act 
            var expected = 3;

            // assert

            Assert.Equal(expected, Customer.instanceCount);

        }

        [Fact]

        public void validateValid() {
            var customer = new Customer();
            customer.EmailAddress = "tanviredu2018@gmail.com";
            customer.LastName = "rahman";
            var expected = true;

            var status = customer.Validate();

            Assert.Equal(expected, status);

            
        }

        [Fact]

        public void RetrieveValid() {

            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "tanviredu2018@gmail.com",
                FirstName = "Tanvir",
                LastName = "Rahman"

            };

            //Act

            var actual = customerRepository.Retrieve(1);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.FirstName, actual.FirstName);




        }

        [Fact]
        public void RetrieveProductValid() {


            // arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "4 Bright Flower",
                ProductName = "Flower"
            };

            // Act

            var actual = productRepository.Retrieve(2);

            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
