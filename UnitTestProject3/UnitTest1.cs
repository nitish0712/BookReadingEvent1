using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCAssignment.Controllers;
using System;
using System.Web.Mvc;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new HomeController();
            var result = controller.Index() as ActionResult;
            Assert.IsNotNull(result);
        }
    }
}
