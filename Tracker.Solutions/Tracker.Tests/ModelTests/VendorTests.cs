using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tracker.Models;

namespace Tracker.Test
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateAnInstanceOfVendor_Vendor()
    {
      string vendorName = "Test Name";
      Vendor newVendor = new Vendor(vendorName);

      Assert.AreEqual(typeof(Vendor), newVendor.GetType()); 
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string vendorName = "Test Name";
      Vendor newVendor = new Vendor(vendorName);

      string result = newVendor.VendorName; 

      Assert.AreEqual(vendorName, result); 
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_int()
    {
      int intendedId = 1; 
      string vendorName = "Test Name";
      Vendor newVendor = new Vendor(vendorName);

      int result = newVendor.Id; 

      Assert.AreEqual(intendedId, result); 
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "Test Name #1";
      string vendorName2 = "Test Name #2";
      Vendor vendor1 = new Vendor(vendorName1);
      Vendor vendor2 = new Vendor(vendorName2);

      List<Vendor> intendedList = new List<Vendor> {vendor1, vendor2}; 
      List<Vendor> result = Vendor.GetAll(); 

      Assert.AreEqual(intendedList, result); 
    }
  }
}