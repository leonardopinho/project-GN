using Microsoft.VisualStudio.TestTools.UnitTesting;
using project_gn.Models;
using project_gn.Repository;
using System.Collections.Generic;
using System.Diagnostics;

namespace project_gn.Tests.Repository
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void GetAll()
        {
            CustomerRepository customer = new CustomerRepository();
            List<Customer> result = customer.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count > 0, true);
        }

        [TestMethod]
        public void GetById()
        {
            CustomerRepository customer = new CustomerRepository();
            Customer result = customer.GetById(1);
            Trace.WriteLine(result.Name);

            Assert.AreEqual("Roberto da Silva", result.Name);
            Assert.IsNotNull(result);
        }
    }
}
