using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StubMockFakeDemo;

namespace StarBuckFakeTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_Message()
        {
            StarBuckNew store = new StarBuckNew(new FakeStarBucksStore());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
        }
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingStub()
        {
            StarBuckNew store = new StarBuckNew(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
        }
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingMock()
        {
            var service = new Mock<ICoffee>();
            service.Setup(x => x.CheckIngridentAvalability()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is received.");
            var store = new StarBuckNew(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
        }
    }
}
