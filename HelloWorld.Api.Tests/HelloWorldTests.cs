using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Api.Controllers;
using HelloWorld.NoDatabase;

namespace HelloWorld.Api.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void TestGet()
        {
            HelloController controller = new HelloController(new MemoryHelloProvider());
            var getresults = controller.Get();
            Assert.IsTrue(getresults == "Hello World");

            controller.Post("NewValue");
            getresults = controller.Get();
            Assert.IsTrue(getresults == "NewValue");
        }
    }
}
