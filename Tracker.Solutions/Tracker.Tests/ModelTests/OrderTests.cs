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
      string orderDescription = "Test Description";
      Order newOrder = new Order(orderTitle, orderDescription); 
      Assert.AreEqual(typeof(Order), newOrder.GetType()); 
    }
    
    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Test Name";
      string orderDescription = "Test Description";
      Order newOrder = new Order(orderTitle, orderDescription);

      string result = newOrder.OrderTitle; 

      Assert.AreEqual(orderTitle, result); 
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string orderTitle = "Test Name";
      string orderDescription = "Test Description";
      Order newOrder = new Order(orderTitle, orderDescription);

      string result = newOrder.OrderDescription; 

      Assert.AreEqual(orderDescription, result); 
    }
  }
}

