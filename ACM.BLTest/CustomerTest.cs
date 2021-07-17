using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "Ahmed",
                LastName = "Mohamed"
            };
            var expected = "Mohamed,Ahmed";
            //act
            var actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Mohamed"
            };
            var expected = "Mohamed";

            //act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "Ahmed"
            };
            var expected = "Ahmed";

            //act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer {FirstName = "Ahmed"};
            Customer.InstanceCount += 1;

            var c2 = new Customer {FirstName = "mohamed"};
            Customer.InstanceCount += 1;

            var c3 = new Customer {FirstName = "Esmail"};
            Customer.InstanceCount += 1;

            //Assert
            Assert.AreEqual(Customer.InstanceCount, 3);
            
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Mohamed",
                EmailAddress = "ahmed@gmail.com"
            };
            var expected = true;
            // Act
            var actual = customer.Validate();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer()
            {
                EmailAddress = "ahmed@gmail.com"
            };
            var expected = false;
            // Act
            var actual = customer.Validate();
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
