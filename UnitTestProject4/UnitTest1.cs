using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCAssignment.Controllers;
using System;
using System.Web.Mvc;

namespace UnitTestProject4
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

        [TestMethod]
        public void TestMethod2()
        {
            var controller = new RegisterController();
            var result = controller.Register() as ActionResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var controller = new BookReadingEventController();
            var result = controller.AllEvents() as ActionResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var controller = new BookReadingEventController();
            var result = controller.CreateEvent() as ActionResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("",result.ViewName);
        }
    }

}
