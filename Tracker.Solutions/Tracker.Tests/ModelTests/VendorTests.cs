using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;

namespace Tracker.Test
{
  [TestClass]
  public class VendorTest
  {
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

      Assert.AreEqual("vendorName", result); 
    }
  }
}