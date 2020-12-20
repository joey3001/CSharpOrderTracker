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
      string orderTitle = "Test Name";
      Order newOrder = new Order(orderTitle); 
      Assert.AreEqual(typeof(Order), newOrder.GetType()); 
    }
    
    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Test Name";
      Order newOrder = new Order(orderTitle);

      string result = newOrder.OrderTitle; 

      Assert.AreEqual(orderTitle, result); 
    }
  }
}