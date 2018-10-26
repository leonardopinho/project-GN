using Microsoft.VisualStudio.TestTools.UnitTesting;
using project_gn.Controllers;
using System.Web.Mvc;

namespace project_gn.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CustomerController controller = new CustomerController();

            controller.Index();

            // Act
            //ViewResult result = controller.Index() as ViewResult;

            // Assert
            //Assert.IsNotNull(null);
        }

    }
}
