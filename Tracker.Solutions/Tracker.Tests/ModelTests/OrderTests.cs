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
      string orderTitle = "Test Title";
      string orderDescription = "Test Description";
      int orderPrice = 10;
      string orderDate = "1/1/1900"; 

      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate); 

      Assert.AreEqual(typeof(Order), newOrder.GetType()); 
    }
    
    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Test Description";
      int orderPrice = 10;
      string orderDate = "1/1/1900"; 
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate); 

      string result = newOrder.OrderTitle; 

      Assert.AreEqual(orderTitle, result); 
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Test Description";
      int orderPrice = 10;
      string orderDate = "1/1/1900"; 
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate); 

      string result = newOrder.OrderDescription; 

      Assert.AreEqual(orderDescription, result); 
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_int()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Test Description";
      int orderPrice = 10;
      string orderDate = "1/1/1900"; 
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate); 

      int result = newOrder.OrderPrice; 

      Assert.AreEqual(orderPrice, result); 
    }

    [TestMethod]
    public void GetOrderDate_ReturnsDateOrderWasPlaced_string()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Test Description";
      int orderPrice = 10;
      string orderDate = "1/1/1900"; 
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate); 

      string result = newOrder.OrderDate; 

      Assert.AreEqual(orderDate, result); 
    }

    [TestMethod]
    public void GetAll_ReturnsListOfOrders_OrderList()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Test Description";
      int orderPrice = 10;
      string orderDate = "1/1/1900"; 
      string orderTitle2 = "Test Title 2";
      string orderDescription2 = "Test Description 2";
      int orderPrice2 = 12;
      string orderDate2 = "1/2/1900"; 
      Order newOrder1 = new Order(orderTitle, orderDescription, orderPrice, orderDate); 
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderPrice2, orderDate2);
      List<Order> intendedList = new List<Order> { newOrder1, newOrder2 };

      string result = Order.GetAll(); 

      CollectionAssert.AreEqual(intendedList, result); 
    }
  }
}

