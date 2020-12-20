using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models; 
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreateAnInstanceOfOrder_Order()
    {
      Order newOrder = new Order(); 
      Assert.AreEqual(typeof(string), newOrder.GetType()); 
    }
  }
}