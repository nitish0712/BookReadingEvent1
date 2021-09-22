using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCAssignment.Controllers;
using System;
using System.Web.Mvc;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new HomeController();
            var result = controller.About() as ActionResult;
            Assert.IsNotNull(result);
        }
    }
}
