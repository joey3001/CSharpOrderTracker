using System.Collections.Generic;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTest
  {
    public void OrderConstructor_CreateAnInstanceOfOrder_Order()
    {
      Order newOrder = new Order(); 
      Assert.AreEqual(typeof(string), newOrder); 
    }
  }
}