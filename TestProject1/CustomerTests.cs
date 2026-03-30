using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject1
    {
        [TestClass]
        public class CustomerTests
        {
            [TestMethod]
            public void AddCustomer_ShouldWork()
            {
                // Arrange
                var service = new CustomerService();

                var customer = new Customer
                {
                    FirstName = "Test",
                    LastName = "User",
                    Email = "test@test.com",
                    Phone = "0000000000"
                };

                // Act
                service.Add(customer);

                // Assert
                var all = service.GetAll();
                Assert.IsTrue(all.Any(c => c.Email == "test@test.com"), "Пътникът не беше добавен успешно.");
            }

            [TestMethod]
            public void DeleteCustomer_ShouldRemoveCustomer()
            {
                // Arrange
                var service = new CustomerService();

                var customer = new Customer
                {
                    FirstName = "Delete",
                    LastName = "Me",
                    Email = "delete@test.com",
                    Phone = "1111111111"
                };

                service.Add(customer);
                var addedCustomer = service.GetAll().Last();

                // Act
                service.Delete(addedCustomer.CustomerId);

                // Assert
                var allAfterDelete = service.GetAll();
                Assert.IsFalse(allAfterDelete.Any(c => c.CustomerId == addedCustomer.CustomerId), "Пътникът не беше изтрит.");
            }
        }
    }
